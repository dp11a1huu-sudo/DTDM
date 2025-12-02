using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BUS
{
    // =============================================
    // BUS CLASSES FOR DUKA FOOTBALL MANAGEMENT SYSTEM
    // =============================================

    public class BUS_Field
    {
        private DAL_Field dalField;

        public BUS_Field()
        {
            dalField = new DAL_Field();
        }

        public DataTable GetAllFields()
        {
            try
            {
                return dalField.GetAllFields();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách sân: " + ex.Message);
            }
        }

        public DataTable GetActiveFields()
        {
            try
            {
                return dalField.GetActiveFields();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách sân hoạt động: " + ex.Message);
            }
        }

        public DTO_Field GetFieldById(int fieldId)
        {
            try
            {
                DataTable dt = dalField.GetFieldById(fieldId);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    return new DTO_Field
                    {
                        FieldID = Convert.ToInt32(row["FieldID"]),
                        FieldCode = row["FieldCode"].ToString(),
                        FieldName = row["FieldName"].ToString(),
                        FieldType = row["FieldType"].ToString(),
                        Area = Convert.ToDecimal(row["Area"]),
                        SurfaceType = row["SurfaceType"].ToString(),
                        Status = row["Status"].ToString(),
                        PriceHigh = Convert.ToDecimal(row["PriceHigh"]),
                        PriceNormal = Convert.ToDecimal(row["PriceNormal"]),
                        PriceLow = Convert.ToDecimal(row["PriceLow"]),
                        CreatedDate = Convert.ToDateTime(row["CreatedDate"]),
                        Notes = row["Notes"]?.ToString()
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thông tin sân: " + ex.Message);
            }
        }

        public bool AddField(DTO_Field field)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(field.FieldCode))
                throw new ArgumentException("Mã sân không được để trống");

            if (string.IsNullOrWhiteSpace(field.FieldName))
                throw new ArgumentException("Tên sân không được để trống");

            if (!Regex.IsMatch(field.FieldCode, @"^SB\d{3}$"))
                throw new ArgumentException("Mã sân phải có định dạng SB001, SB002, ...");

            if (field.Area <= 0)
                throw new ArgumentException("Diện tích phải lớn hơn 0");

            if (field.PriceHigh <= 0 || field.PriceNormal <= 0 || field.PriceLow <= 0)
                throw new ArgumentException("Giá phải lớn hơn 0");

            if (field.PriceHigh < field.PriceNormal || field.PriceNormal < field.PriceLow)
                throw new ArgumentException("Giá cao > giá thường > giá thấp");

            if (dalField.IsFieldCodeExists(field.FieldCode))
                throw new ArgumentException("Mã sân đã tồn tại");

            try
            {
                int newId = dalField.InsertField(field);
                return newId > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm sân: " + ex.Message);
            }
        }

        public bool UpdateField(DTO_Field field)
        {
            // Validation
            if (field.FieldID <= 0)
                throw new ArgumentException("ID sân không hợp lệ");

            if (string.IsNullOrWhiteSpace(field.FieldCode))
                throw new ArgumentException("Mã sân không được để trống");

            if (string.IsNullOrWhiteSpace(field.FieldName))
                throw new ArgumentException("Tên sân không được để trống");

            if (field.Area <= 0)
                throw new ArgumentException("Diện tích phải lớn hơn 0");

            if (field.PriceHigh <= 0 || field.PriceNormal <= 0 || field.PriceLow <= 0)
                throw new ArgumentException("Giá phải lớn hơn 0");

            if (field.PriceHigh < field.PriceNormal || field.PriceNormal < field.PriceLow)
                throw new ArgumentException("Giá cao > giá thường > giá thấp");

            if (dalField.IsFieldCodeExists(field.FieldCode, field.FieldID))
                throw new ArgumentException("Mã sân đã tồn tại");

            try
            {
                return dalField.UpdateField(field);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật sân: " + ex.Message);
            }
        }

        public bool DeleteField(int fieldId)
        {
            try
            {
                // Check if field has bookings
                DataTable bookings = GetBookingsByField(fieldId);
                if (bookings.Rows.Count > 0)
                {
                    throw new ArgumentException("Không thể xóa sân đã có lịch đặt");
                }

                return dalField.DeleteField(fieldId);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa sân: " + ex.Message);
            }
        }

        public DataTable GetFieldAvailability(int fieldId, DateTime date)
        {
            try
            {
                return dalField.GetFieldAvailability(fieldId, date);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra lịch sân: " + ex.Message);
            }
        }

        public DataTable GetFieldStatistics()
        {
            try
            {
                return dalField.GetFieldStatistics();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thống kê sân: " + ex.Message);
            }
        }

        public DataTable GetBookingsByField(int fieldId, DateTime? date = null)
        {
            try
            {
                return dalField.GetBookingsByField(fieldId, date);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy lịch đặt sân: " + ex.Message);
            }
        }
    }

    public class BUS_Booking
    {
        private DAL_Booking dalBooking;
        private BUS_Field busField;
        private BUS_Customer busCustomer;

        public BUS_Booking()
        {
            dalBooking = new DAL_Booking();
            busField = new BUS_Field();
            busCustomer = new BUS_Customer();
        }

        public DataTable GetAllBookings()
        {
            try
            {
                return dalBooking.GetAllBookings();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách đặt sân: " + ex.Message);
            }
        }

        public DataTable GetBookingsByDate(DateTime date)
        {
            try
            {
                return dalBooking.GetBookingsByDate(date);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy lịch đặt theo ngày: " + ex.Message);
            }
        }

        public bool CreateBooking(DTO_Booking booking)
        {
            // Validation
            if (booking.FieldID <= 0)
                throw new ArgumentException("Vui lòng chọn sân");

            if (booking.CustomerID <= 0)
                throw new ArgumentException("Vui lòng chọn khách hàng");

            if (booking.BookingDate.Date < DateTime.Today)
                throw new ArgumentException("Không thể đặt sân cho ngày trong quá khứ");

            if (booking.StartTime >= booking.EndTime)
                throw new ArgumentException("Thời gian kết thúc phải sau thời gian bắt đầu");

            if (booking.CreatedBy <= 0)
                throw new ArgumentException("Thông tin người tạo không hợp lệ");

            // Check field availability
            if (dalBooking.CheckBookingConflict(booking.FieldID, booking.BookingDate,
                                               booking.StartTime, booking.EndTime))
            {
                throw new ArgumentException("Sân đã được đặt trong khung giờ này");
            }

            // Generate booking code
            booking.BookingCode = dalBooking.GenerateBookingCode();
            booking.Status = "Pending";

            // Calculate price based on time slot
            DTO_Field field = busField.GetFieldById(booking.FieldID);
            if (field != null)
            {
                TimeSpan duration = booking.EndTime - booking.StartTime;
                decimal hours = (decimal)duration.TotalHours;

                // Simple pricing logic (can be enhanced)
                if (booking.StartTime.Hours >= 17 || booking.StartTime.Hours < 6) // Peak hours
                    booking.Price = field.PriceHigh * hours;
                else if (booking.StartTime.Hours >= 11 && booking.StartTime.Hours < 17) // Normal hours
                    booking.Price = field.PriceNormal * hours;
                else // Off-peak
                    booking.Price = field.PriceLow * hours;
            }

            try
            {
                int newId = dalBooking.InsertBooking(booking);
                if (newId > 0)
                {
                    // Update customer statistics
                    busCustomer.UpdateCustomerStats(booking.CustomerID);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tạo đơn đặt sân: " + ex.Message);
            }
        }

        public bool UpdateBooking(DTO_Booking booking)
        {
            // Validation
            if (booking.BookingID <= 0)
                throw new ArgumentException("ID đặt sân không hợp lệ");

            if (booking.FieldID <= 0)
                throw new ArgumentException("Vui lòng chọn sân");

            if (booking.CustomerID <= 0)
                throw new ArgumentException("Vui lòng chọn khách hàng");

            if (booking.StartTime >= booking.EndTime)
                throw new ArgumentException("Thời gian kết thúc phải sau thời gian bắt đầu");

            // Check field availability (exclude current booking)
            if (dalBooking.CheckBookingConflict(booking.FieldID, booking.BookingDate,
                                               booking.StartTime, booking.EndTime, booking.BookingID))
            {
                throw new ArgumentException("Sân đã được đặt trong khung giờ này");
            }

            try
            {
                bool result = dalBooking.UpdateBooking(booking);
                if (result)
                {
                    // Update customer statistics
                    busCustomer.UpdateCustomerStats(booking.CustomerID);
                }
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật đặt sân: " + ex.Message);
            }
        }

        public bool ConfirmBooking(int bookingId, string paymentMethod)
        {
            try
            {
                // Get booking details
                DataTable dt = dalBooking.GetAllBookings();
                DataRow[] rows = dt.Select($"BookingID = {bookingId}");

                if (rows.Length == 0)
                    throw new ArgumentException("Không tìm thấy đơn đặt sân");

                DataRow row = rows[0];
                DTO_Booking booking = new DTO_Booking
                {
                    BookingID = bookingId,
                    Status = "Confirmed",
                    PaymentMethod = paymentMethod
                };

                return dalBooking.UpdateBooking(booking);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xác nhận đặt sân: " + ex.Message);
            }
        }

        public bool MarkAsPaid(int bookingId)
        {
            try
            {
                DataTable dt = dalBooking.GetAllBookings();
                DataRow[] rows = dt.Select($"BookingID = {bookingId}");

                if (rows.Length == 0)
                    throw new ArgumentException("Không tìm thấy đơn đặt sân");

                DataRow row = rows[0];
                DTO_Booking booking = new DTO_Booking
                {
                    BookingID = bookingId,
                    Status = "Paid",
                    PaidDate = DateTime.Now
                };

                bool result = dalBooking.UpdateBooking(booking);
                if (result)
                {
                    // Update customer statistics
                    int customerId = Convert.ToInt32(row["CustomerID"]);
                    busCustomer.UpdateCustomerStats(customerId);
                }
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thanh toán: " + ex.Message);
            }
        }

        public bool CancelBooking(int bookingId)
        {
            try
            {
                DataTable dt = dalBooking.GetAllBookings();
                DataRow[] rows = dt.Select($"BookingID = {bookingId}");

                if (rows.Length == 0)
                    throw new ArgumentException("Không tìm thấy đơn đặt sân");

                DataRow row = rows[0];
                string currentStatus = row["Status"].ToString();

                if (currentStatus == "Paid")
                    throw new ArgumentException("Không thể hủy đơn đã thanh toán");

                DTO_Booking booking = new DTO_Booking
                {
                    BookingID = bookingId,
                    Status = "Cancelled"
                };

                return dalBooking.UpdateBooking(booking);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi hủy đặt sân: " + ex.Message);
            }
        }

        public DataTable GetRevenueByDateRange(DateTime startDate, DateTime endDate)
        {
            try
            {
                return dalBooking.GetRevenueByDateRange(startDate, endDate);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy báo cáo doanh thu: " + ex.Message);
            }
        }

        public string GenerateBookingCode()
        {
            try
            {
                return dalBooking.GenerateBookingCode();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tạo mã đặt sân: " + ex.Message);
            }
        }
    }

    public class BUS_Customer
    {
        private DAL_Customer dalCustomer;

        public BUS_Customer()
        {
            dalCustomer = new DAL_Customer();
        }

        public DataTable GetAllCustomers()
        {
            try
            {
                return dalCustomer.GetAllCustomers();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách khách hàng: " + ex.Message);
            }
        }

        public DTO_Customer GetCustomerById(int customerId)
        {
            try
            {
                DataTable dt = dalCustomer.GetCustomerById(customerId);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    return new DTO_Customer
                    {
                        CustomerID = Convert.ToInt32(row["CustomerID"]),
                        FullName = row["FullName"].ToString(),
                        Phone = row["Phone"].ToString(),
                        Email = row["Email"]?.ToString(),
                        Address = row["Address"]?.ToString(),
                        TotalBookings = Convert.ToInt32(row["TotalBookings"]),
                        TotalSpent = Convert.ToDecimal(row["TotalSpent"]),
                        LastBookingDate = row["LastBookingDate"] != DBNull.Value ?
                                         Convert.ToDateTime(row["LastBookingDate"]) : (DateTime?)null,
                        FavoriteFieldType = row["FavoriteFieldType"]?.ToString(),
                        CreatedDate = Convert.ToDateTime(row["CreatedDate"]),
                        Notes = row["Notes"]?.ToString()
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thông tin khách hàng: " + ex.Message);
            }
        }

        public DTO_Customer GetCustomerByPhone(string phone)
        {
            try
            {
                DataTable dt = dalCustomer.GetCustomerByPhone(phone);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    return new DTO_Customer
                    {
                        CustomerID = Convert.ToInt32(row["CustomerID"]),
                        FullName = row["FullName"].ToString(),
                        Phone = row["Phone"].ToString(),
                        Email = row["Email"]?.ToString(),
                        Address = row["Address"]?.ToString(),
                        TotalBookings = Convert.ToInt32(row["TotalBookings"]),
                        TotalSpent = Convert.ToDecimal(row["TotalSpent"]),
                        LastBookingDate = row["LastBookingDate"] != DBNull.Value ?
                                         Convert.ToDateTime(row["LastBookingDate"]) : (DateTime?)null,
                        FavoriteFieldType = row["FavoriteFieldType"]?.ToString(),
                        CreatedDate = Convert.ToDateTime(row["CreatedDate"]),
                        Notes = row["Notes"]?.ToString()
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm khách hàng theo số điện thoại: " + ex.Message);
            }
        }

        public bool AddCustomer(DTO_Customer customer)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(customer.FullName))
                throw new ArgumentException("Tên khách hàng không được để trống");

            if (string.IsNullOrWhiteSpace(customer.Phone))
                throw new ArgumentException("Số điện thoại không được để trống");

            if (!Regex.IsMatch(customer.Phone, @"^(0|\+84)[3-9][0-9]{8}$"))
                throw new ArgumentException("Số điện thoại không hợp lệ");

            if (dalCustomer.IsPhoneExists(customer.Phone))
                throw new ArgumentException("Số điện thoại đã tồn tại");

            if (!string.IsNullOrWhiteSpace(customer.Email) &&
                !Regex.IsMatch(customer.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new ArgumentException("Email không hợp lệ");

            try
            {
                int newId = dalCustomer.InsertCustomer(customer);
                return newId > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm khách hàng: " + ex.Message);
            }
        }

        public bool UpdateCustomer(DTO_Customer customer)
        {
            // Validation
            if (customer.CustomerID <= 0)
                throw new ArgumentException("ID khách hàng không hợp lệ");

            if (string.IsNullOrWhiteSpace(customer.FullName))
                throw new ArgumentException("Tên khách hàng không được để trống");

            if (string.IsNullOrWhiteSpace(customer.Phone))
                throw new ArgumentException("Số điện thoại không được để trống");

            if (!Regex.IsMatch(customer.Phone, @"^(0|\+84)[3-9][0-9]{8}$"))
                throw new ArgumentException("Số điện thoại không hợp lệ");

            if (dalCustomer.IsPhoneExists(customer.Phone, customer.CustomerID))
                throw new ArgumentException("Số điện thoại đã tồn tại");

            if (!string.IsNullOrWhiteSpace(customer.Email) &&
                !Regex.IsMatch(customer.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new ArgumentException("Email không hợp lệ");

            try
            {
                return dalCustomer.UpdateCustomer(customer);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật khách hàng: " + ex.Message);
            }
        }

        public bool UpdateCustomerStats(int customerId)
        {
            try
            {
                return dalCustomer.UpdateCustomerStats(customerId);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật thống kê khách hàng: " + ex.Message);
            }
        }

        public DataTable GetTopCustomers(int topCount = 10)
        {
            try
            {
                return dalCustomer.GetTopCustomers(topCount);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách khách hàng tiềm năng: " + ex.Message);
            }
        }

        public DataTable SearchCustomers(string searchTerm)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(searchTerm))
                    return GetAllCustomers();

                return dalCustomer.SearchCustomers(searchTerm);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm kiếm khách hàng: " + ex.Message);
            }
        }
    }

    public class BUS_User
    {
        private DAL_User dalUser;

        public BUS_User()
        {
            dalUser = new DAL_User();
        }

        public DTO_User Login(string username, string password)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Tên đăng nhập không được để trống");

            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Mật khẩu không được để trống");

            try
            {
                // Hash password (SHA256)
                string passwordHash = ComputeSHA256(password);

                DataTable dt = dalUser.GetUserByCredentials(username, passwordHash);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    DTO_User user = new DTO_User
                    {
                        UserID = Convert.ToInt32(row["UserID"]),
                        Username = row["Username"].ToString(),
                        PasswordHash = row["PasswordHash"].ToString(),
                        FullName = row["FullName"].ToString(),
                        Email = row["Email"]?.ToString(),
                        Phone = row["Phone"]?.ToString(),
                        Role = row["Role"].ToString(),
                        IsActive = Convert.ToBoolean(row["IsActive"]),
                        CreatedDate = Convert.ToDateTime(row["CreatedDate"]),
                        LastLogin = row["LastLogin"] != DBNull.Value ?
                                   Convert.ToDateTime(row["LastLogin"]) : (DateTime?)null
                    };

                    // Update last login
                    dalUser.UpdateLastLogin(user.UserID);

                    return user;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi đăng nhập: " + ex.Message);
            }
        }

        public bool ChangePassword(int userId, string oldPassword, string newPassword)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(oldPassword))
                throw new ArgumentException("Mật khẩu cũ không được để trống");

            if (string.IsNullOrWhiteSpace(newPassword))
                throw new ArgumentException("Mật khẩu mới không được để trống");

            if (newPassword.Length < 6)
                throw new ArgumentException("Mật khẩu mới phải có ít nhất 6 ký tự");

            try
            {
                // Get current user
                DataTable dt = dalUser.GetAllUsers();
                DataRow[] rows = dt.Select($"UserID = {userId}");

                if (rows.Length == 0)
                    throw new ArgumentException("Không tìm thấy thông tin người dùng");

                DataRow row = rows[0];
                string currentHash = row["PasswordHash"].ToString();
                string oldHash = ComputeSHA256(oldPassword);

                if (currentHash != oldHash)
                    throw new ArgumentException("Mật khẩu cũ không đúng");

                // This would require a DAL method to update password
                // For now, throw not implemented
                throw new NotImplementedException("Chức năng đổi mật khẩu chưa được triển khai");
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi đổi mật khẩu: " + ex.Message);
            }
        }

        private string ComputeSHA256(string input)
        {
            using (System.Security.Cryptography.SHA256 sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input);
                byte[] hash = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }
    }

    // Dashboard Business Logic
    public class BUS_Dashboard
    {
        public DTO_DashboardStats GetDashboardStats()
        {
            try
            {
                DTO_DashboardStats stats = new DTO_DashboardStats();

                // Get field counts
                string fieldQuery = @"SELECT
                                        COUNT(*) as TotalFields,
                                        SUM(CASE WHEN Status = 'Active' THEN 1 ELSE 0 END) as ActiveFields
                                     FROM Fields";

                DataTable fieldDt = DAL.DataProvider.ExecuteQuery(fieldQuery);
                if (fieldDt.Rows.Count > 0)
                {
                    stats.TotalFields = Convert.ToInt32(fieldDt.Rows[0]["TotalFields"]);
                    stats.ActiveFields = Convert.ToInt32(fieldDt.Rows[0]["ActiveFields"]);
                }

                // Get today's bookings and revenue
                string todayQuery = @"SELECT
                                        COUNT(*) as BookingCount,
                                        ISNULL(SUM(Price), 0) as Revenue
                                     FROM Bookings
                                     WHERE BookingDate = CAST(GETDATE() AS DATE)
                                     AND Status = 'Paid'";

                DataTable todayDt = DAL.DataProvider.ExecuteQuery(todayQuery);
                if (todayDt.Rows.Count > 0)
                {
                    stats.TotalBookingsToday = Convert.ToInt32(todayDt.Rows[0]["BookingCount"]);
                    stats.TotalRevenueToday = Convert.ToDecimal(todayDt.Rows[0]["Revenue"]);
                }

                // Get customer count
                string customerQuery = "SELECT COUNT(*) as CustomerCount FROM Customers";
                DataTable customerDt = DAL.DataProvider.ExecuteQuery(customerQuery);
                if (customerDt.Rows.Count > 0)
                {
                    stats.TotalCustomers = Convert.ToInt32(customerDt.Rows[0]["CustomerCount"]);
                }

                // Get employee count
                string employeeQuery = "SELECT COUNT(*) as EmployeeCount FROM Employees WHERE IsActive = 1";
                DataTable employeeDt = DAL.DataProvider.ExecuteQuery(employeeQuery);
                if (employeeDt.Rows.Count > 0)
                {
                    stats.TotalEmployees = Convert.ToInt32(employeeDt.Rows[0]["EmployeeCount"]);
                }

                // Get maintenance count
                string maintenanceQuery = @"SELECT COUNT(*) as MaintenanceCount
                                           FROM Maintenance
                                           WHERE Status IN ('Pending', 'InProgress')";

                DataTable maintenanceDt = DAL.DataProvider.ExecuteQuery(maintenanceQuery);
                if (maintenanceDt.Rows.Count > 0)
                {
                    stats.PendingMaintenance = Convert.ToInt32(maintenanceDt.Rows[0]["MaintenanceCount"]);
                }

                // Get monthly revenue
                string monthlyQuery = @"SELECT ISNULL(SUM(Price), 0) as MonthlyRevenue
                                       FROM Bookings
                                       WHERE MONTH(BookingDate) = MONTH(GETDATE())
                                       AND YEAR(BookingDate) = YEAR(GETDATE())
                                       AND Status = 'Paid'";

                DataTable monthlyDt = DAL.DataProvider.ExecuteQuery(monthlyQuery);
                if (monthlyDt.Rows.Count > 0)
                {
                    stats.MonthlyRevenue = Convert.ToDecimal(monthlyDt.Rows[0]["MonthlyRevenue"]);
                }

                return stats;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thống kê dashboard: " + ex.Message);
            }
        }

        public DataTable GetRevenueChartData(int days = 30)
        {
            try
            {
                string query = @"SELECT
                                    CAST(BookingDate AS DATE) as Date,
                                    COUNT(*) as BookingCount,
                                    ISNULL(SUM(Price), 0) as Revenue
                                FROM Bookings
                                WHERE BookingDate >= DATEADD(DAY, -@Days, CAST(GETDATE() AS DATE))
                                AND Status = 'Paid'
                                GROUP BY CAST(BookingDate AS DATE)
                                ORDER BY Date";

                System.Data.SqlClient.SqlParameter[] parameters = {
                    new System.Data.SqlClient.SqlParameter("@Days", days)
                };

                return DAL.DataProvider.ExecuteQuery(query, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy dữ liệu biểu đồ doanh thu: " + ex.Message);
            }
        }
    }
}
