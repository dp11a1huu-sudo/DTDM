using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    // =============================================
    // DTO CLASSES FOR DUKA FOOTBALL MANAGEMENT SYSTEM
    // =============================================

    public class DTO_User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastLogin { get; set; }

        public DTO_User() { }

        public DTO_User(int userId, string username, string passwordHash, string fullName,
                       string email, string phone, string role, bool isActive,
                       DateTime createdDate, DateTime? lastLogin)
        {
            UserID = userId;
            Username = username;
            PasswordHash = passwordHash;
            FullName = fullName;
            Email = email;
            Phone = phone;
            Role = role;
            IsActive = isActive;
            CreatedDate = createdDate;
            LastLogin = lastLogin;
        }
    }

    public class DTO_Field
    {
        public int FieldID { get; set; }
        public string FieldCode { get; set; }
        public string FieldName { get; set; }
        public string FieldType { get; set; }
        public decimal Area { get; set; }
        public string SurfaceType { get; set; }
        public string Status { get; set; }
        public decimal PriceHigh { get; set; }
        public decimal PriceNormal { get; set; }
        public decimal PriceLow { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Notes { get; set; }

        public DTO_Field() { }

        public DTO_Field(int fieldId, string fieldCode, string fieldName, string fieldType,
                        decimal area, string surfaceType, string status, decimal priceHigh,
                        decimal priceNormal, decimal priceLow, DateTime createdDate, string notes)
        {
            FieldID = fieldId;
            FieldCode = fieldCode;
            FieldName = fieldName;
            FieldType = fieldType;
            Area = area;
            SurfaceType = surfaceType;
            Status = status;
            PriceHigh = priceHigh;
            PriceNormal = priceNormal;
            PriceLow = priceLow;
            CreatedDate = createdDate;
            Notes = notes;
        }
    }

    public class DTO_Customer
    {
        public int CustomerID { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int TotalBookings { get; set; }
        public decimal TotalSpent { get; set; }
        public DateTime? LastBookingDate { get; set; }
        public string FavoriteFieldType { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Notes { get; set; }

        public DTO_Customer() { }

        public DTO_Customer(int customerId, string fullName, string phone, string email,
                           string address, int totalBookings, decimal totalSpent,
                           DateTime? lastBookingDate, string favoriteFieldType,
                           DateTime createdDate, string notes)
        {
            CustomerID = customerId;
            FullName = fullName;
            Phone = phone;
            Email = email;
            Address = address;
            TotalBookings = totalBookings;
            TotalSpent = totalSpent;
            LastBookingDate = lastBookingDate;
            FavoriteFieldType = favoriteFieldType;
            CreatedDate = createdDate;
            Notes = notes;
        }
    }

    public class DTO_Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeCode { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public decimal BaseSalary { get; set; }
        public int? UserID { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }

        public DTO_Employee() { }

        public DTO_Employee(int employeeId, string employeeCode, string fullName, string phone,
                           string email, string position, decimal baseSalary, int? userId,
                           bool isActive, DateTime createdDate)
        {
            EmployeeID = employeeId;
            EmployeeCode = employeeCode;
            FullName = fullName;
            Phone = phone;
            Email = email;
            Position = position;
            BaseSalary = baseSalary;
            UserID = userId;
            IsActive = isActive;
            CreatedDate = createdDate;
        }
    }

    public class DTO_Booking
    {
        public int BookingID { get; set; }
        public string BookingCode { get; set; }
        public int FieldID { get; set; }
        public int CustomerID { get; set; }
        public DateTime BookingDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public decimal Price { get; set; }
        public string PaymentMethod { get; set; }
        public string Status { get; set; }
        public int CreatedBy { get; set; } // Nhân viên tạo booking
        public DateTime CreatedDate { get; set; }
        public DateTime? PaidDate { get; set; }
        public string Notes { get; set; }

        // Navigation properties
        public string FieldName { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CreatedByName { get; set; } // Tên nhân viên

        public DTO_Booking() { }

        public DTO_Booking(int bookingId, string bookingCode, int fieldId, int customerId,
                          DateTime bookingDate, TimeSpan startTime, TimeSpan endTime,
                          decimal price, string paymentMethod, string status, int createdBy,
                          DateTime createdDate, DateTime? paidDate, string notes)
        {
            BookingID = bookingId;
            BookingCode = bookingCode;
            FieldID = fieldId;
            CustomerID = customerId;
            BookingDate = bookingDate;
            StartTime = startTime;
            EndTime = endTime;
            Price = price;
            PaymentMethod = paymentMethod;
            Status = status;
            CreatedBy = createdBy;
            CreatedDate = createdDate;
            PaidDate = paidDate;
            Notes = notes;
        }
    }

    public class DTO_WorkShift
    {
        public int ShiftID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime WorkDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Status { get; set; }
        public DateTime? ConfirmedAt { get; set; }
        public string Notes { get; set; }

        // Navigation properties
        public string EmployeeName { get; set; }

        public DTO_WorkShift() { }

        public DTO_WorkShift(int shiftId, int employeeId, DateTime workDate,
                           TimeSpan startTime, TimeSpan endTime, string status,
                           DateTime? confirmedAt, string notes)
        {
            ShiftID = shiftId;
            EmployeeID = employeeId;
            WorkDate = workDate;
            StartTime = startTime;
            EndTime = endTime;
            Status = status;
            ConfirmedAt = confirmedAt;
            Notes = notes;
        }
    }

    public class DTO_Equipment
    {
        public int EquipmentID { get; set; }
        public string EquipmentCode { get; set; }
        public string EquipmentName { get; set; }
        public string EquipmentType { get; set; }
        public int? FieldID { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public DateTime? WarrantyExpiry { get; set; }
        public DateTime CreatedDate { get; set; }

        // Navigation properties
        public string FieldName { get; set; }

        public DTO_Equipment() { }

        public DTO_Equipment(int equipmentId, string equipmentCode, string equipmentName,
                           string equipmentType, int? fieldId, int quantity, string status,
                           DateTime? purchaseDate, DateTime? warrantyExpiry, DateTime createdDate)
        {
            EquipmentID = equipmentId;
            EquipmentCode = equipmentCode;
            EquipmentName = equipmentName;
            EquipmentType = equipmentType;
            FieldID = fieldId;
            Quantity = quantity;
            Status = status;
            PurchaseDate = purchaseDate;
            WarrantyExpiry = warrantyExpiry;
            CreatedDate = createdDate;
        }
    }

    public class DTO_FoodService
    {
        public int FoodServiceID { get; set; }
        public string ServiceName { get; set; }
        public string ServiceType { get; set; }
        public decimal UnitPrice { get; set; }
        public int StockQuantity { get; set; }
        public string Unit { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }

        public DTO_FoodService() { }

        public DTO_FoodService(int foodServiceId, string serviceName, string serviceType,
                             decimal unitPrice, int stockQuantity, string unit, bool isActive,
                             DateTime createdDate)
        {
            FoodServiceID = foodServiceId;
            ServiceName = serviceName;
            ServiceType = serviceType;
            UnitPrice = unitPrice;
            StockQuantity = stockQuantity;
            Unit = unit;
            IsActive = isActive;
            CreatedDate = createdDate;
        }
    }

    public class DTO_RentalService
    {
        public int RentalServiceID { get; set; }
        public string ServiceName { get; set; }
        public string ServiceType { get; set; }
        public decimal UnitPrice { get; set; }
        public int AvailableQuantity { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }

        public DTO_RentalService() { }

        public DTO_RentalService(int rentalServiceId, string serviceName, string serviceType,
                               decimal unitPrice, int availableQuantity, string status,
                               DateTime createdDate)
        {
            RentalServiceID = rentalServiceId;
            ServiceName = serviceName;
            ServiceType = serviceType;
            UnitPrice = unitPrice;
            AvailableQuantity = availableQuantity;
            Status = status;
            CreatedDate = createdDate;
        }
    }

    public class DTO_Salary
    {
        public int SalaryID { get; set; }
        public int EmployeeID { get; set; }
        public int SalaryMonth { get; set; }
        public int SalaryYear { get; set; }
        public decimal BaseSalary { get; set; }
        public int ShiftCount { get; set; }
        public decimal ShiftRate { get; set; }
        public decimal Allowance { get; set; }
        public decimal Deduction { get; set; }
        public decimal TotalSalary { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        // Navigation properties
        public string EmployeeName { get; set; }

        public DTO_Salary() { }

        public DTO_Salary(int salaryId, int employeeId, int salaryMonth, int salaryYear,
                         decimal baseSalary, int shiftCount, decimal shiftRate, decimal allowance,
                         decimal deduction, decimal totalSalary, int createdBy, DateTime createdDate)
        {
            SalaryID = salaryId;
            EmployeeID = employeeId;
            SalaryMonth = salaryMonth;
            SalaryYear = salaryYear;
            BaseSalary = baseSalary;
            ShiftCount = shiftCount;
            ShiftRate = shiftRate;
            Allowance = allowance;
            Deduction = deduction;
            TotalSalary = totalSalary;
            CreatedBy = createdBy;
            CreatedDate = createdDate;
        }
    }

    public class DTO_Expense
    {
        public int ExpenseID { get; set; }
        public DateTime ExpenseDate { get; set; }
        public string ExpenseType { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        // Navigation properties
        public string CreatedByName { get; set; }

        public DTO_Expense() { }

        public DTO_Expense(int expenseId, DateTime expenseDate, string expenseType,
                          decimal amount, string description, int createdBy, DateTime createdDate)
        {
            ExpenseID = expenseId;
            ExpenseDate = expenseDate;
            ExpenseType = expenseType;
            Amount = amount;
            Description = description;
            CreatedBy = createdBy;
            CreatedDate = createdDate;
        }
    }

    public class DTO_BookingService
    {
        public int BookingServiceID { get; set; }
        public int BookingID { get; set; }
        public string ServiceType { get; set; }
        public int? FoodServiceID { get; set; }
        public int? RentalServiceID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }

        // Navigation properties
        public string ServiceName { get; set; }

        public DTO_BookingService() { }

        public DTO_BookingService(int bookingServiceId, int bookingId, string serviceType,
                                int? foodServiceId, int? rentalServiceId, int quantity,
                                decimal unitPrice, decimal totalPrice)
        {
            BookingServiceID = bookingServiceId;
            BookingID = bookingId;
            ServiceType = serviceType;
            FoodServiceID = foodServiceId;
            RentalServiceID = rentalServiceId;
            Quantity = quantity;
            UnitPrice = unitPrice;
            TotalPrice = totalPrice;
        }
    }

    public class DTO_Maintenance
    {
        public int MaintenanceID { get; set; }
        public string MaintenanceCode { get; set; }
        public int? EquipmentID { get; set; }
        public int? FieldID { get; set; }
        public string Description { get; set; }
        public int? AssignedTo { get; set; }
        public decimal Cost { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? ExpectedEndDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public string Status { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        // Navigation properties
        public string EquipmentName { get; set; }
        public string FieldName { get; set; }
        public string AssignedToName { get; set; }

        public DTO_Maintenance() { }

        public DTO_Maintenance(int maintenanceId, string maintenanceCode, int? equipmentId,
                             int? fieldId, string description, int? assignedTo, decimal cost,
                             DateTime startDate, DateTime? expectedEndDate, DateTime? actualEndDate,
                             string status, int createdBy, DateTime createdDate)
        {
            MaintenanceID = maintenanceId;
            MaintenanceCode = maintenanceCode;
            EquipmentID = equipmentId;
            FieldID = fieldId;
            Description = description;
            AssignedTo = assignedTo;
            Cost = cost;
            StartDate = startDate;
            ExpectedEndDate = expectedEndDate;
            ActualEndDate = actualEndDate;
            Status = status;
            CreatedBy = createdBy;
            CreatedDate = createdDate;
        }
    }

    // =============================================
    // DASHBOARD DTOs
    // =============================================

    public class DTO_DashboardStats
    {
        public int TotalFields { get; set; }
        public int ActiveFields { get; set; }
        public int TotalBookingsToday { get; set; }
        public decimal TotalRevenueToday { get; set; }
        public int TotalCustomers { get; set; }
        public int TotalEmployees { get; set; }
        public int PendingMaintenance { get; set; }
        public decimal MonthlyRevenue { get; set; }
    }

    public class DTO_FieldAvailability
    {
        public int FieldID { get; set; }
        public string FieldName { get; set; }
        public string FieldType { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public bool IsAvailable { get; set; }
        public string BookedBy { get; set; }
    }

    public class DTO_RevenueSummary
    {
        public DateTime Date { get; set; }
        public decimal FieldRevenue { get; set; }
        public decimal ServiceRevenue { get; set; }
        public decimal TotalRevenue { get; set; }
        public int BookingCount { get; set; }
    }
}
