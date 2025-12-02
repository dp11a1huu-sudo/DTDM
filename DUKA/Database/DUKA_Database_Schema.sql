-- =============================================
-- Database Schema for DUKA - Mini Football Management System
-- Version: 1.0
-- Created: 2025
-- =============================================

CREATE DATABASE IF NOT EXISTS DUKA_FootballManagement;
USE DUKA_FootballManagement;

-- =============================================
-- 1. Bảng Người dùng (Users)
-- =============================================
DROP TABLE IF EXISTS Users;
CREATE TABLE Users (
    UserID INT AUTO_INCREMENT PRIMARY KEY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    PasswordHash VARCHAR(256) NOT NULL,
    FullName VARCHAR(100) NOT NULL,
    Email VARCHAR(100),
    Phone VARCHAR(20),
    Role VARCHAR(20) NOT NULL CHECK (Role IN ('Admin', 'Staff')), -- BR-008
    IsActive TINYINT DEFAULT 1,
    CreatedDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    LastLogin DATETIME
);

-- =============================================
-- 2. Bảng Sân bóng (Fields)
-- =============================================
DROP TABLE IF EXISTS Fields;
CREATE TABLE Fields (
    FieldID INT AUTO_INCREMENT PRIMARY KEY,
    FieldCode VARCHAR(20) NOT NULL UNIQUE, -- BR-001: Mã định danh duy nhất
    FieldName VARCHAR(100) NOT NULL,
    FieldType VARCHAR(20) NOT NULL, -- 5 người, 7 người
    Area DECIMAL(10,2),
    SurfaceType VARCHAR(50), -- Cỏ nhân tạo, cỏ tự nhiên
    Status VARCHAR(20) DEFAULT 'Active' CHECK (Status IN ('Active', 'Maintenance', 'Closed')), -- BR-003
    PriceHigh DECIMAL(18,0), -- Giá cao điểm
    PriceNormal DECIMAL(18,0), -- Giá thường
    PriceLow DECIMAL(18,0), -- Giá thấp điểm
    CreatedDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    Notes VARCHAR(500)
);

-- =============================================
-- 3. Bảng Khách hàng (Customers)
-- =============================================
DROP TABLE IF EXISTS Customers;
CREATE TABLE Customers (
    CustomerID INT AUTO_INCREMENT PRIMARY KEY,
    FullName VARCHAR(100) NOT NULL,
    Phone VARCHAR(20) NOT NULL UNIQUE,
    Email VARCHAR(100),
    Address VARCHAR(200),
    TotalBookings INT DEFAULT 0,
    TotalSpent DECIMAL(18,0) DEFAULT 0,
    LastBookingDate DATETIME,
    FavoriteFieldType VARCHAR(20),
    CreatedDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    Notes VARCHAR(500)
);

-- =============================================
-- 4. Bảng Nhân viên (Employees)
-- =============================================
DROP TABLE IF EXISTS Employees;
CREATE TABLE Employees (
    EmployeeID INT AUTO_INCREMENT PRIMARY KEY,
    EmployeeCode VARCHAR(20) NOT NULL UNIQUE,
    FullName VARCHAR(100) NOT NULL,
    Phone VARCHAR(20),
    Email VARCHAR(100),
    Position VARCHAR(50), -- Lễ tân, Quản lý, Bảo trì, Kế toán
    BaseSalary DECIMAL(18,0) DEFAULT 0,
    UserID INT NULL, -- Liên kết với Users nếu có tài khoản
    IsActive TINYINT DEFAULT 1,
    CreatedDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

-- =============================================
-- 5. Bảng Ca làm việc (WorkShifts)
-- =============================================
DROP TABLE IF EXISTS WorkShifts;
CREATE TABLE WorkShifts (
    ShiftID INT AUTO_INCREMENT PRIMARY KEY,
    EmployeeID INT NOT NULL,
    WorkDate DATE NOT NULL,
    StartTime TIME NOT NULL,
    EndTime TIME NOT NULL,
    Status VARCHAR(20) DEFAULT 'Scheduled' CHECK (Status IN ('Scheduled', 'Completed', 'Absent')), -- BR-009
    ConfirmedAt DATETIME NULL,
    Notes VARCHAR(500),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);

-- =============================================
-- 6. Bảng Đặt sân (Bookings)
-- =============================================
DROP TABLE IF EXISTS Bookings;
CREATE TABLE Bookings (
    BookingID INT AUTO_INCREMENT PRIMARY KEY,
    BookingCode VARCHAR(20) NOT NULL UNIQUE,
    FieldID INT NOT NULL,
    CustomerID INT NOT NULL,
    BookingDate DATE NOT NULL,
    StartTime TIME NOT NULL,
    EndTime TIME NOT NULL,
    Price DECIMAL(18,0) NOT NULL,
    PaymentMethod VARCHAR(20) CHECK (PaymentMethod IN ('Cash', 'Transfer', 'QR')), -- BR-002
    Status VARCHAR(20) DEFAULT 'Pending' CHECK (Status IN ('Pending', 'Confirmed', 'Paid', 'Cancelled')), -- BR-004
    CreatedBy INT NOT NULL, -- UserID của nhân viên tạo
    CreatedDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    PaidDate DATETIME NULL,
    Notes VARCHAR(500),
    FOREIGN KEY (FieldID) REFERENCES Fields(FieldID),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID),
    FOREIGN KEY (CreatedBy) REFERENCES Users(UserID)
);

-- =============================================
-- 7. Bảng Hóa đơn (Invoices)
-- =============================================
DROP TABLE IF EXISTS Invoices;
CREATE TABLE Invoices (
    InvoiceID INT AUTO_INCREMENT PRIMARY KEY,
    InvoiceCode VARCHAR(20) NOT NULL UNIQUE, -- BR-011
    BookingID INT NOT NULL,
    TotalAmount DECIMAL(18,0) NOT NULL,
    ServiceAmount DECIMAL(18,0) DEFAULT 0, -- Dịch vụ phụ trợ
    Discount DECIMAL(18,0) DEFAULT 0,
    FinalAmount DECIMAL(18,0) NOT NULL,
    CreatedBy INT NOT NULL,
    CreatedDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (BookingID) REFERENCES Bookings(BookingID),
    FOREIGN KEY (CreatedBy) REFERENCES Users(UserID)
);

-- =============================================
-- 8. Bảng Thiết bị (Equipment)
-- =============================================
DROP TABLE IF EXISTS Equipment;
CREATE TABLE Equipment (
    EquipmentID INT AUTO_INCREMENT PRIMARY KEY,
    EquipmentCode VARCHAR(20) NOT NULL UNIQUE,
    EquipmentName VARCHAR(100) NOT NULL,
    EquipmentType VARCHAR(50), -- Đèn, khung thành, cỏ, ghế, máy bơm nước
    FieldID INT NULL, -- NULL nếu dùng chung, BR-007
    Quantity INT DEFAULT 1,
    Status VARCHAR(20) DEFAULT 'Good' CHECK (Status IN ('Good', 'MinorIssue', 'NeedReplacement')), -- BR-006
    PurchaseDate DATE,
    WarrantyExpiry DATE,
    CreatedDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (FieldID) REFERENCES Fields(FieldID)
);

-- =============================================
-- 9. Bảng Bảo trì (Maintenance)
-- =============================================
DROP TABLE IF EXISTS Maintenance;
CREATE TABLE Maintenance (
    MaintenanceID INT AUTO_INCREMENT PRIMARY KEY,
    MaintenanceCode VARCHAR(20) NOT NULL UNIQUE,
    EquipmentID INT NULL,
    FieldID INT NULL,
    Description VARCHAR(500) NOT NULL,
    AssignedTo INT NULL, -- EmployeeID
    Cost DECIMAL(18,0) DEFAULT 0,
    StartDate DATETIME NOT NULL,
    ExpectedEndDate DATETIME,
    ActualEndDate DATETIME NULL,
    Status VARCHAR(20) DEFAULT 'Pending' CHECK (Status IN ('Pending', 'InProgress', 'Completed', 'Cancelled')), -- BR-006
    CreatedBy INT NOT NULL,
    CreatedDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (EquipmentID) REFERENCES Equipment(EquipmentID),
    FOREIGN KEY (FieldID) REFERENCES Fields(FieldID),
    FOREIGN KEY (AssignedTo) REFERENCES Employees(EmployeeID),
    FOREIGN KEY (CreatedBy) REFERENCES Users(UserID)
);

-- =============================================
-- 10. Bảng Dịch vụ ăn uống (FoodServices)
-- =============================================
DROP TABLE IF EXISTS FoodServices;
CREATE TABLE FoodServices (
    FoodServiceID INT AUTO_INCREMENT PRIMARY KEY,
    ServiceName VARCHAR(100) NOT NULL,
    ServiceType VARCHAR(20) CHECK (ServiceType IN ('Food', 'Drink')),
    UnitPrice DECIMAL(18,0) NOT NULL,
    StockQuantity INT DEFAULT 0,
    Unit VARCHAR(20) DEFAULT 'Item',
    IsActive TINYINT DEFAULT 1,
    CreatedDate DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- =============================================
-- 11. Bảng Dịch vụ thuê (RentalServices)
-- =============================================
DROP TABLE IF EXISTS RentalServices;
CREATE TABLE RentalServices (
    RentalServiceID INT AUTO_INCREMENT PRIMARY KEY,
    ServiceName VARCHAR(100) NOT NULL,
    ServiceType VARCHAR(50), -- Trọng tài, Áo, Giày, Bóng, Dụng cụ thi đấu
    UnitPrice DECIMAL(18,0) NOT NULL,
    AvailableQuantity INT DEFAULT 0,
    Status VARCHAR(20) DEFAULT 'Available' CHECK (Status IN ('Available', 'Rented', 'Maintenance')),
    CreatedDate DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- =============================================
-- 12. Bảng Chi tiết dịch vụ đặt sân (BookingServices)
-- =============================================
DROP TABLE IF EXISTS BookingServices;
CREATE TABLE BookingServices (
    BookingServiceID INT AUTO_INCREMENT PRIMARY KEY,
    BookingID INT NOT NULL,
    ServiceType VARCHAR(20) CHECK (ServiceType IN ('Food', 'Rental')),
    FoodServiceID INT NULL,
    RentalServiceID INT NULL,
    Quantity INT NOT NULL DEFAULT 1,
    UnitPrice DECIMAL(18,0) NOT NULL,
    TotalPrice DECIMAL(18,0) NOT NULL,
    FOREIGN KEY (BookingID) REFERENCES Bookings(BookingID),
    FOREIGN KEY (FoodServiceID) REFERENCES FoodServices(FoodServiceID),
    FOREIGN KEY (RentalServiceID) REFERENCES RentalServices(RentalServiceID)
);

-- =============================================
-- 13. Bảng Lương nhân viên (Salaries)
-- =============================================
DROP TABLE IF EXISTS Salaries;
CREATE TABLE Salaries (
    SalaryID INT AUTO_INCREMENT PRIMARY KEY,
    EmployeeID INT NOT NULL,
    SalaryMonth INT NOT NULL, -- 1-12
    SalaryYear INT NOT NULL,
    BaseSalary DECIMAL(18,0) NOT NULL,
    ShiftCount INT DEFAULT 0,
    ShiftRate DECIMAL(18,0) DEFAULT 0, -- Đơn giá ca
    Allowance DECIMAL(18,0) DEFAULT 0, -- Phụ cấp
    Deduction DECIMAL(18,0) DEFAULT 0, -- Khấu trừ
    TotalSalary DECIMAL(18,0) NOT NULL, -- BR-010
    CreatedBy INT NOT NULL,
    CreatedDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID),
    FOREIGN KEY (CreatedBy) REFERENCES Users(UserID)
);

-- =============================================
-- 14. Bảng Chi phí (Expenses)
-- =============================================
DROP TABLE IF EXISTS Expenses;
CREATE TABLE Expenses (
    ExpenseID INT AUTO_INCREMENT PRIMARY KEY,
    ExpenseDate DATE NOT NULL,
    ExpenseType VARCHAR(50), -- Bảo trì, Vật tư, Tiền điện, Tiền nước, Lương, Khác
    Amount DECIMAL(18,0) NOT NULL,
    Description VARCHAR(500),
    CreatedBy INT NOT NULL,
    CreatedDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (CreatedBy) REFERENCES Users(UserID)
);

-- =============================================
-- INSERT DỮ LIỆU MẪU
-- =============================================

-- Admin mặc định (password: admin123 - SHA256 hash)
INSERT INTO Users (Username, PasswordHash, FullName, Email, Role) 
VALUES ('admin', '240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9', 'Quản trị viên', 'admin@duka.com', 'Admin');

-- Nhân viên mẫu
INSERT INTO Users (Username, PasswordHash, FullName, Email, Phone, Role) 
VALUES ('staff01', '240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9', 'Nhân viên 01', 'staff01@duka.com', '0123456789', 'Staff');

-- Sân bóng mẫu
INSERT INTO Fields (FieldCode, FieldName, FieldType, Area, SurfaceType, Status, PriceHigh, PriceNormal, PriceLow)
VALUES 
('SB001', 'Sân số 1', '5 người', 200, 'Cỏ nhân tạo', 'Active', 300000, 250000, 200000),
('SB002', 'Sân số 2', '5 người', 200, 'Cỏ nhân tạo', 'Active', 300000, 250000, 200000),
('SB003', 'Sân số 3', '7 người', 350, 'Cỏ nhân tạo', 'Active', 400000, 350000, 300000);

-- Dịch vụ ăn uống mẫu
INSERT INTO FoodServices (ServiceName, ServiceType, UnitPrice, StockQuantity)
VALUES 
('Nước suối', 'Drink', 10000, 100),
('Coca Cola', 'Drink', 15000, 50),
('Bánh mì', 'Food', 20000, 30);

-- Dịch vụ thuê mẫu
INSERT INTO RentalServices (ServiceName, ServiceType, UnitPrice, AvailableQuantity)
VALUES 
('Thuê trọng tài', 'Trọng tài', 100000, 5),
('Áo thi đấu', 'Áo', 50000, 20),
('Bóng', 'Bóng', 30000, 10);

-- =============================================
-- TẠO INDEX ĐỂ TỐI ƯU HIỆU NĂNG
-- =============================================
CREATE INDEX IX_Bookings_FieldDate ON Bookings(FieldID, BookingDate);
CREATE INDEX IX_Bookings_Customer ON Bookings(CustomerID);
CREATE INDEX IX_WorkShifts_EmployeeDate ON WorkShifts(EmployeeID, WorkDate);
CREATE INDEX IX_Salaries_EmployeeMonth ON Salaries(EmployeeID, SalaryYear, SalaryMonth);

-- =============================================
-- TẠO TRIGGERS ĐỂ THAY THẾ CHECK CONSTRAINTS PHỨC TẠP
-- =============================================

-- Trigger để kiểm tra trùng ca làm việc (BR-009)
DELIMITER $$
CREATE TRIGGER CheckOverlappingShifts
BEFORE INSERT ON WorkShifts
FOR EACH ROW
BEGIN
    IF EXISTS (
        SELECT 1 FROM WorkShifts ws2 
        WHERE ws2.EmployeeID = NEW.EmployeeID 
        AND ws2.WorkDate = NEW.WorkDate
        AND ws2.ShiftID != NEW.ShiftID
        AND (
            (ws2.StartTime < NEW.EndTime AND ws2.EndTime > NEW.StartTime)
        )
    ) THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Không được trùng ca làm việc cho cùng một nhân viên trong cùng ngày';
    END IF;
END$$
DELIMITER ;

-- Trigger để kiểm tra trùng lịch đặt sân (BR-004)
DELIMITER $$
CREATE TRIGGER CheckOverlappingBookings
BEFORE INSERT ON Bookings
FOR EACH ROW
BEGIN
    IF EXISTS (
        SELECT 1 FROM Bookings b2 
        WHERE b2.FieldID = NEW.FieldID 
        AND b2.BookingDate = NEW.BookingDate
        AND b2.BookingID != NEW.BookingID
        AND b2.Status NOT IN ('Cancelled')
        AND (
            (b2.StartTime < NEW.EndTime AND b2.EndTime > NEW.StartTime)
        )
    ) THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Không được trùng lịch đặt sân';
    END IF;
END$$
DELIMITER ;
SELECT 'Database schema created successfully!' AS Status;
