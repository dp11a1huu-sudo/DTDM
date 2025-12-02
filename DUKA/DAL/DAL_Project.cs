using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    // =============================================
    // DAL CLASSES FOR DUKA FOOTBALL MANAGEMENT SYSTEM
    // =============================================

    public class DAL_Field
    {
        public DataTable GetAllFields()
        {
            string query = @"SELECT FieldID, FieldCode, FieldName, FieldType, Area, SurfaceType,
                                   Status, PriceHigh, PriceNormal, PriceLow, CreatedDate, Notes
                            FROM Fields ORDER BY FieldCode";
            return DataProvider.ExecuteQuery(query);
        }

        public DataTable GetActiveFields()
        {
            string query = @"SELECT FieldID, FieldCode, FieldName, FieldType, Area, SurfaceType,
                                   Status, PriceHigh, PriceNormal, PriceLow, CreatedDate, Notes
                            FROM Fields WHERE Status = 'Active' ORDER BY FieldCode";
            return DataProvider.ExecuteQuery(query);
        }

        public DataTable GetFieldById(int fieldId)
        {
            string query = @"SELECT FieldID, FieldCode, FieldName, FieldType, Area, SurfaceType,
                                   Status, PriceHigh, PriceNormal, PriceLow, CreatedDate, Notes
                            FROM Fields WHERE FieldID = @FieldID";

            SqlParameter[] parameters = {
                new SqlParameter("@FieldID", fieldId)
            };

            return DataProvider.ExecuteQuery(query, parameters);
        }

        public int InsertField(DTO_Field field)
        {
            string query = @"INSERT INTO Fields (FieldCode, FieldName, FieldType, Area, SurfaceType,
                                                Status, PriceHigh, PriceNormal, PriceLow, Notes)
                            VALUES (@FieldCode, @FieldName, @FieldType, @Area, @SurfaceType,
                                   @Status, @PriceHigh, @PriceNormal, @PriceLow, @Notes);
                            SELECT SCOPE_IDENTITY();";

            SqlParameter[] parameters = {
                new SqlParameter("@FieldCode", field.FieldCode),
                new SqlParameter("@FieldName", field.FieldName),
                new SqlParameter("@FieldType", field.FieldType),
                new SqlParameter("@Area", field.Area),
                new SqlParameter("@SurfaceType", field.SurfaceType),
                new SqlParameter("@Status", field.Status),
                new SqlParameter("@PriceHigh", field.PriceHigh),
                new SqlParameter("@PriceNormal", field.PriceNormal),
                new SqlParameter("@PriceLow", field.PriceLow),
                new SqlParameter("@Notes", field.Notes ?? (object)DBNull.Value)
            };

            return Convert.ToInt32(DataProvider.ExecuteScalar(query, parameters));
        }

        public bool UpdateField(DTO_Field field)
        {
            string query = @"UPDATE Fields SET
                                FieldCode = @FieldCode,
                                FieldName = @FieldName,
                                FieldType = @FieldType,
                                Area = @Area,
                                SurfaceType = @SurfaceType,
                                Status = @Status,
                                PriceHigh = @PriceHigh,
                                PriceNormal = @PriceNormal,
                                PriceLow = @PriceLow,
                                Notes = @Notes
                            WHERE FieldID = @FieldID";

            SqlParameter[] parameters = {
                new SqlParameter("@FieldID", field.FieldID),
                new SqlParameter("@FieldCode", field.FieldCode),
                new SqlParameter("@FieldName", field.FieldName),
                new SqlParameter("@FieldType", field.FieldType),
                new SqlParameter("@Area", field.Area),
                new SqlParameter("@SurfaceType", field.SurfaceType),
                new SqlParameter("@Status", field.Status),
                new SqlParameter("@PriceHigh", field.PriceHigh),
                new SqlParameter("@PriceNormal", field.PriceNormal),
                new SqlParameter("@PriceLow", field.PriceLow),
                new SqlParameter("@Notes", field.Notes ?? (object)DBNull.Value)
            };

            return DataProvider.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeleteField(int fieldId)
        {
            string query = "DELETE FROM Fields WHERE FieldID = @FieldID";

            SqlParameter[] parameters = {
                new SqlParameter("@FieldID", fieldId)
            };

            return DataProvider.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool IsFieldCodeExists(string fieldCode, int? excludeFieldId = null)
        {
            string query = "SELECT COUNT(*) FROM Fields WHERE FieldCode = @FieldCode";
            if (excludeFieldId.HasValue)
            {
                query += " AND FieldID != @ExcludeFieldID";
            }

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@FieldCode", fieldCode)
            };

            if (excludeFieldId.HasValue)
            {
                parameters.Add(new SqlParameter("@ExcludeFieldID", excludeFieldId.Value));
            }

            int count = Convert.ToInt32(DataProvider.ExecuteScalar(query, parameters.ToArray()));
            return count > 0;
        }

        public DataTable GetFieldAvailability(int fieldId, DateTime date)
        {
            string query = @"SELECT b.StartTime, b.EndTime, c.FullName as CustomerName
                            FROM Bookings b
                            INNER JOIN Customers c ON b.CustomerID = c.CustomerID
                            WHERE b.FieldID = @FieldID
                            AND b.BookingDate = @BookingDate
                            AND b.Status NOT IN ('Cancelled')
                            ORDER BY b.StartTime";

            SqlParameter[] parameters = {
                new SqlParameter("@FieldID", fieldId),
                new SqlParameter("@BookingDate", date.Date)
            };

            return DataProvider.ExecuteQuery(query, parameters);
        }

        public DataTable GetFieldStatistics()
        {
            string query = @"SELECT
                                f.FieldType,
                                COUNT(*) as TotalFields,
                                SUM(CASE WHEN f.Status = 'Active' THEN 1 ELSE 0 END) as ActiveFields,
                                AVG(f.Area) as AvgArea,
                                AVG(f.PriceNormal) as AvgPrice
                            FROM Fields f
                            GROUP BY f.FieldType
                            ORDER BY f.FieldType";

            return DataProvider.ExecuteQuery(query);
        }
    }

    public class DAL_Booking
    {
        public DataTable GetAllBookings()
        {
            string query = @"SELECT b.*, f.FieldName, c.FullName as CustomerName, u.FullName as CreatedByName
                            FROM Bookings b
                            INNER JOIN Fields f ON b.FieldID = f.FieldID
                            INNER JOIN Customers c ON b.CustomerID = c.CustomerID
                            INNER JOIN Users u ON b.CreatedBy = u.UserID
                            ORDER BY b.CreatedDate DESC";

            return DataProvider.ExecuteQuery(query);
        }

        public DataTable GetBookingsByDate(DateTime date)
        {
            string query = @"SELECT b.*, f.FieldName, c.FullName as CustomerName, u.FullName as CreatedByName
                            FROM Bookings b
                            INNER JOIN Fields f ON b.FieldID = f.FieldID
                            INNER JOIN Customers c ON b.CustomerID = c.CustomerID
                            INNER JOIN Users u ON b.CreatedBy = u.UserID
                            WHERE b.BookingDate = @BookingDate
                            ORDER BY b.StartTime";

            SqlParameter[] parameters = {
                new SqlParameter("@BookingDate", date.Date)
            };

            return DataProvider.ExecuteQuery(query, parameters);
        }

        public DataTable GetBookingsByField(int fieldId, DateTime? date = null)
        {
            string query = @"SELECT b.*, c.FullName as CustomerName, u.FullName as CreatedByName
                            FROM Bookings b
                            INNER JOIN Customers c ON b.CustomerID = c.CustomerID
                            INNER JOIN Users u ON b.CreatedBy = u.UserID
                            WHERE b.FieldID = @FieldID";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@FieldID", fieldId)
            };

            if (date.HasValue)
            {
                query += " AND b.BookingDate = @BookingDate";
                parameters.Add(new SqlParameter("@BookingDate", date.Value.Date));
            }

            query += " ORDER BY b.BookingDate DESC, b.StartTime";

            return DataProvider.ExecuteQuery(query, parameters.ToArray());
        }

        public int InsertBooking(DTO_Booking booking)
        {
            string query = @"INSERT INTO Bookings (BookingCode, FieldID, CustomerID, BookingDate,
                                                   StartTime, EndTime, Price, PaymentMethod,
                                                   Status, CreatedBy, Notes)
                            VALUES (@BookingCode, @FieldID, @CustomerID, @BookingDate,
                                   @StartTime, @EndTime, @Price, @PaymentMethod,
                                   @Status, @CreatedBy, @Notes);
                            SELECT SCOPE_IDENTITY();";

            SqlParameter[] parameters = {
                new SqlParameter("@BookingCode", booking.BookingCode),
                new SqlParameter("@FieldID", booking.FieldID),
                new SqlParameter("@CustomerID", booking.CustomerID),
                new SqlParameter("@BookingDate", booking.BookingDate.Date),
                new SqlParameter("@StartTime", booking.StartTime),
                new SqlParameter("@EndTime", booking.EndTime),
                new SqlParameter("@Price", booking.Price),
                new SqlParameter("@PaymentMethod", booking.PaymentMethod),
                new SqlParameter("@Status", booking.Status),
                new SqlParameter("@CreatedBy", booking.CreatedBy),
                new SqlParameter("@Notes", booking.Notes ?? (object)DBNull.Value)
            };

            return Convert.ToInt32(DataProvider.ExecuteScalar(query, parameters));
        }

        public bool UpdateBooking(DTO_Booking booking)
        {
            string query = @"UPDATE Bookings SET
                                FieldID = @FieldID,
                                CustomerID = @CustomerID,
                                BookingDate = @BookingDate,
                                StartTime = @StartTime,
                                EndTime = @EndTime,
                                Price = @Price,
                                PaymentMethod = @PaymentMethod,
                                Status = @Status,
                                PaidDate = @PaidDate,
                                Notes = @Notes
                            WHERE BookingID = @BookingID";

            SqlParameter[] parameters = {
                new SqlParameter("@BookingID", booking.BookingID),
                new SqlParameter("@FieldID", booking.FieldID),
                new SqlParameter("@CustomerID", booking.CustomerID),
                new SqlParameter("@BookingDate", booking.BookingDate.Date),
                new SqlParameter("@StartTime", booking.StartTime),
                new SqlParameter("@EndTime", booking.EndTime),
                new SqlParameter("@Price", booking.Price),
                new SqlParameter("@PaymentMethod", booking.PaymentMethod),
                new SqlParameter("@Status", booking.Status),
                new SqlParameter("@PaidDate", booking.PaidDate ?? (object)DBNull.Value),
                new SqlParameter("@Notes", booking.Notes ?? (object)DBNull.Value)
            };

            return DataProvider.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeleteBooking(int bookingId)
        {
            string query = "DELETE FROM Bookings WHERE BookingID = @BookingID";

            SqlParameter[] parameters = {
                new SqlParameter("@BookingID", bookingId)
            };

            return DataProvider.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool CheckBookingConflict(int fieldId, DateTime bookingDate, TimeSpan startTime, TimeSpan endTime, int? excludeBookingId = null)
        {
            string query = @"SELECT COUNT(*) FROM Bookings
                            WHERE FieldID = @FieldID
                            AND BookingDate = @BookingDate
                            AND Status NOT IN ('Cancelled')";

            if (excludeBookingId.HasValue)
            {
                query += " AND BookingID != @ExcludeBookingID";
            }

            query += @" AND (
                        (StartTime < @EndTime AND EndTime > @StartTime)
                      )";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@FieldID", fieldId),
                new SqlParameter("@BookingDate", bookingDate.Date),
                new SqlParameter("@StartTime", startTime),
                new SqlParameter("@EndTime", endTime)
            };

            if (excludeBookingId.HasValue)
            {
                parameters.Add(new SqlParameter("@ExcludeBookingID", excludeBookingId.Value));
            }

            int count = Convert.ToInt32(DataProvider.ExecuteScalar(query, parameters.ToArray()));
            return count > 0;
        }

        public DataTable GetRevenueByDateRange(DateTime startDate, DateTime endDate)
        {
            string query = @"SELECT
                                b.BookingDate,
                                COUNT(*) as BookingCount,
                                SUM(b.Price) as TotalRevenue
                            FROM Bookings b
                            WHERE b.BookingDate BETWEEN @StartDate AND @EndDate
                            AND b.Status = 'Paid'
                            GROUP BY b.BookingDate
                            ORDER BY b.BookingDate";

            SqlParameter[] parameters = {
                new SqlParameter("@StartDate", startDate.Date),
                new SqlParameter("@EndDate", endDate.Date)
            };

            return DataProvider.ExecuteQuery(query, parameters);
        }

        public string GenerateBookingCode()
        {
            string query = @"SELECT 'BK' + RIGHT('00000' + CAST(ISNULL(MAX(CAST(SUBSTRING(BookingCode, 3, LEN(BookingCode)) AS INT)), 0) + 1 AS VARCHAR), 5)
                            FROM Bookings
                            WHERE BookingCode LIKE 'BK%' AND ISNUMERIC(SUBSTRING(BookingCode, 3, LEN(BookingCode))) = 1";

            object result = DataProvider.ExecuteScalar(query);
            return result?.ToString() ?? "BK00001";
        }
    }

    public class DAL_Customer
    {
        public DataTable GetAllCustomers()
        {
            string query = @"SELECT CustomerID, FullName, Phone, Email, Address,
                                   TotalBookings, TotalSpent, LastBookingDate,
                                   FavoriteFieldType, CreatedDate, Notes
                            FROM Customers ORDER BY FullName";

            return DataProvider.ExecuteQuery(query);
        }

        public DataTable GetCustomerById(int customerId)
        {
            string query = @"SELECT CustomerID, FullName, Phone, Email, Address,
                                   TotalBookings, TotalSpent, LastBookingDate,
                                   FavoriteFieldType, CreatedDate, Notes
                            FROM Customers WHERE CustomerID = @CustomerID";

            SqlParameter[] parameters = {
                new SqlParameter("@CustomerID", customerId)
            };

            return DataProvider.ExecuteQuery(query, parameters);
        }

        public DataTable GetCustomerByPhone(string phone)
        {
            string query = @"SELECT CustomerID, FullName, Phone, Email, Address,
                                   TotalBookings, TotalSpent, LastBookingDate,
                                   FavoriteFieldType, CreatedDate, Notes
                            FROM Customers WHERE Phone = @Phone";

            SqlParameter[] parameters = {
                new SqlParameter("@Phone", phone)
            };

            return DataProvider.ExecuteQuery(query, parameters);
        }

        public int InsertCustomer(DTO_Customer customer)
        {
            string query = @"INSERT INTO Customers (FullName, Phone, Email, Address,
                                                   FavoriteFieldType, Notes)
                            VALUES (@FullName, @Phone, @Email, @Address,
                                   @FavoriteFieldType, @Notes);
                            SELECT SCOPE_IDENTITY();";

            SqlParameter[] parameters = {
                new SqlParameter("@FullName", customer.FullName),
                new SqlParameter("@Phone", customer.Phone),
                new SqlParameter("@Email", customer.Email ?? (object)DBNull.Value),
                new SqlParameter("@Address", customer.Address ?? (object)DBNull.Value),
                new SqlParameter("@FavoriteFieldType", customer.FavoriteFieldType ?? (object)DBNull.Value),
                new SqlParameter("@Notes", customer.Notes ?? (object)DBNull.Value)
            };

            return Convert.ToInt32(DataProvider.ExecuteScalar(query, parameters));
        }

        public bool UpdateCustomer(DTO_Customer customer)
        {
            string query = @"UPDATE Customers SET
                                FullName = @FullName,
                                Phone = @Phone,
                                Email = @Email,
                                Address = @Address,
                                FavoriteFieldType = @FavoriteFieldType,
                                Notes = @Notes
                            WHERE CustomerID = @CustomerID";

            SqlParameter[] parameters = {
                new SqlParameter("@CustomerID", customer.CustomerID),
                new SqlParameter("@FullName", customer.FullName),
                new SqlParameter("@Phone", customer.Phone),
                new SqlParameter("@Email", customer.Email ?? (object)DBNull.Value),
                new SqlParameter("@Address", customer.Address ?? (object)DBNull.Value),
                new SqlParameter("@FavoriteFieldType", customer.FavoriteFieldType ?? (object)DBNull.Value),
                new SqlParameter("@Notes", customer.Notes ?? (object)DBNull.Value)
            };

            return DataProvider.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool UpdateCustomerStats(int customerId)
        {
            string query = @"UPDATE Customers SET
                                TotalBookings = (SELECT COUNT(*) FROM Bookings WHERE CustomerID = @CustomerID AND Status = 'Paid'),
                                TotalSpent = (SELECT ISNULL(SUM(Price), 0) FROM Bookings WHERE CustomerID = @CustomerID AND Status = 'Paid'),
                                LastBookingDate = (SELECT MAX(BookingDate) FROM Bookings WHERE CustomerID = @CustomerID AND Status = 'Paid')
                            WHERE CustomerID = @CustomerID";

            SqlParameter[] parameters = {
                new SqlParameter("@CustomerID", customerId)
            };

            return DataProvider.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool IsPhoneExists(string phone, int? excludeCustomerId = null)
        {
            string query = "SELECT COUNT(*) FROM Customers WHERE Phone = @Phone";
            if (excludeCustomerId.HasValue)
            {
                query += " AND CustomerID != @ExcludeCustomerID";
            }

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@Phone", phone)
            };

            if (excludeCustomerId.HasValue)
            {
                parameters.Add(new SqlParameter("@ExcludeCustomerID", excludeCustomerId.Value));
            }

            int count = Convert.ToInt32(DataProvider.ExecuteScalar(query, parameters.ToArray()));
            return count > 0;
        }

        public DataTable GetTopCustomers(int topCount = 10)
        {
            string query = @"SELECT TOP (@TopCount)
                                CustomerID, FullName, Phone, TotalBookings, TotalSpent, LastBookingDate
                            FROM Customers
                            WHERE TotalBookings > 0
                            ORDER BY TotalSpent DESC";

            SqlParameter[] parameters = {
                new SqlParameter("@TopCount", topCount)
            };

            return DataProvider.ExecuteQuery(query, parameters);
        }

        public DataTable SearchCustomers(string searchTerm)
        {
            string query = @"SELECT CustomerID, FullName, Phone, Email, Address,
                                   TotalBookings, TotalSpent, LastBookingDate
                            FROM Customers
                            WHERE FullName LIKE @SearchTerm
                               OR Phone LIKE @SearchTerm
                               OR Email LIKE @SearchTerm
                            ORDER BY FullName";

            SqlParameter[] parameters = {
                new SqlParameter("@SearchTerm", "%" + searchTerm + "%")
            };

            return DataProvider.ExecuteQuery(query, parameters);
        }
    }

    public class DAL_User
    {
        public DataTable GetAllUsers()
        {
            string query = @"SELECT UserID, Username, PasswordHash, FullName, Email, Phone,
                                   Role, IsActive, CreatedDate, LastLogin
                            FROM Users ORDER BY FullName";

            return DataProvider.ExecuteQuery(query);
        }

        public DataTable GetUserByCredentials(string username, string passwordHash)
        {
            string query = @"SELECT UserID, Username, PasswordHash, FullName, Email, Phone,
                                   Role, IsActive, CreatedDate, LastLogin
                            FROM Users
                            WHERE Username = @Username
                            AND PasswordHash = @PasswordHash
                            AND IsActive = 1";

            SqlParameter[] parameters = {
                new SqlParameter("@Username", username),
                new SqlParameter("@PasswordHash", passwordHash)
            };

            return DataProvider.ExecuteQuery(query, parameters);
        }

        public bool UpdateLastLogin(int userId)
        {
            string query = "UPDATE Users SET LastLogin = GETDATE() WHERE UserID = @UserID";

            SqlParameter[] parameters = {
                new SqlParameter("@UserID", userId)
            };

            return DataProvider.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool IsUsernameExists(string username, int? excludeUserId = null)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
            if (excludeUserId.HasValue)
            {
                query += " AND UserID != @ExcludeUserID";
            }

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@Username", username)
            };

            if (excludeUserId.HasValue)
            {
                parameters.Add(new SqlParameter("@ExcludeUserID", excludeUserId.Value));
            }

            int count = Convert.ToInt32(DataProvider.ExecuteScalar(query, parameters.ToArray()));
            return count > 0;
        }
    }
}
