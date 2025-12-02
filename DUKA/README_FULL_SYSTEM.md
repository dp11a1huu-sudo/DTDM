# DUKA - Hệ thống Quản lý Sân Bóng Mini

## Tổng quan

Hệ thống quản lý sân bóng mini được phát triển theo tài liệu SRS đầy đủ với các chức năng:

### ✅ Đã hoàn thành:

1. **Database Schema** (`Database/DUKA_Database_Schema.sql`)
   - 14 bảng dữ liệu đầy đủ
   - Constraints và Business Rules
   - Dữ liệu mẫu

2. **MainMenu với Sidebar**
   - Dashboard tổng quan
   - Navigation menu đầy đủ
   - Phân quyền Admin/Staff

3. **Các Form Quản lý chính:**
   - ✅ DashboardForm - Thống kê tổng quan
   - ✅ FieldManagementForm - Quản lý sân bóng (UC-001)
   - ✅ FieldDetailForm - Thêm/sửa sân
   - ✅ BookingManagementForm - Đặt sân & Thanh toán (UC-002)
   - ✅ BookingDetailForm - Form đặt sân chi tiết
   - ✅ PaymentForm - Form thanh toán
   - ✅ CustomerManagementForm - Quản lý khách hàng (UC-005)
   - ✅ EmployeeManagementForm - Quản lý nhân viên (UC-006, UC-007, UC-008)
   - ✅ EquipmentManagementForm - Quản lý cơ sở vật chất (UC-003)
   - ✅ RevenueManagementForm - Quản lý doanh thu (UC-004)
   - ✅ ServiceManagementForm - Dịch vụ phụ trợ (UC-009, UC-010)

4. **LoginForm** - Xác thực user với SHA256

### 📋 Cần hoàn thiện (Form Detail):

Các form detail sau cần được tạo tương tự như `FieldDetailForm` và `BookingDetailForm`:

1. **CustomerDetailForm** - Thêm/sửa khách hàng
2. **CustomerHistoryForm** - Lịch sử đặt sân của khách hàng
3. **EmployeeDetailForm** - Thêm/sửa nhân viên
4. **ShiftDetailForm** - Thêm/sửa ca làm việc
5. **CalculateSalaryForm** - Tính lương nhân viên
6. **EquipmentDetailForm** - Thêm/sửa thiết bị
7. **MaintenanceDetailForm** - Tạo phiếu bảo trì
8. **FoodServiceDetailForm** - Thêm/sửa món ăn
9. **RentalServiceDetailForm** - Thêm/sửa dịch vụ thuê

## Hướng dẫn sử dụng

### 1. Tạo Database

```sql
-- Chạy file Database/DUKA_Database_Schema.sql trong SQL Server Management Studio
-- Hoặc sử dụng script:
USE master;
GO
CREATE DATABASE DUKA_FootballManagement;
GO
USE DUKA_FootballManagement;
GO
-- Sau đó chạy toàn bộ script trong file DUKA_Database_Schema.sql
```

### 2. Cấu hình Connection String

- Mở `GUI/App.config`
- Cập nhật:
  ```xml
  <add key="DbServer" value="." />
  <add key="DbName" value="DUKA_FootballManagement" />
  <add key="DbUseWindowsAuth" value="true" />
  ```

### 3. Chạy ứng dụng

- Build solution trong Visual Studio
- Chạy project GUI
- Đăng nhập với:
  - Username: `admin`
  - Password: `admin123`

## Cấu trúc Project

```
DUKA-main/
├── Database/
│   └── DUKA_Database_Schema.sql    # Database schema đầy đủ
├── GUI/
│   ├── Forms/
│   │   ├── LoginForm.cs             # ✅ Hoàn thành
│   │   ├── DashboardForm.cs         # ✅ Hoàn thành
│   │   ├── FieldManagementForm.cs   # ✅ Hoàn thành
│   │   ├── FieldDetailForm.cs       # ✅ Hoàn thành
│   │   ├── BookingManagementForm.cs # ✅ Hoàn thành
│   │   ├── BookingDetailForm.cs     # ✅ Hoàn thành
│   │   ├── PaymentForm.cs           # ✅ Hoàn thành
│   │   ├── CustomerManagementForm.cs # ✅ Hoàn thành
│   │   ├── EmployeeManagementForm.cs # ✅ Hoàn thành
│   │   ├── EquipmentManagementForm.cs # ✅ Hoàn thành
│   │   ├── RevenueManagementForm.cs   # ✅ Hoàn thành
│   │   ├── ServiceManagementForm.cs   # ✅ Hoàn thành
│   │   └── [Các form detail cần tạo]
│   ├── MainMenu.cs                  # ✅ Hoàn thành
│   └── Program.cs                   # ✅ Hoàn thành
└── DAL/
    └── ConfigHelper.cs              # ✅ Hoàn thành
```

## Business Rules đã implement

- ✅ BR-001: Mã định danh sân duy nhất
- ✅ BR-002: Giá thuê theo khung giờ
- ✅ BR-003: Trạng thái sân
- ✅ BR-004: Kiểm tra trùng lịch đặt
- ✅ BR-005: Nhập thông tin bắt buộc
- ✅ BR-008: Phân quyền người dùng
- ✅ BR-011: Hóa đơn nội bộ

## Tính năng chính

### 1. Quản lý sân bóng
- Thêm/sửa/xóa sân
- Quản lý giá theo khung giờ
- Trạng thái sân (Active/Maintenance/Closed)

### 2. Đặt sân & Thanh toán
- Đặt sân với kiểm tra trùng lịch
- Tự động tính giá theo khung giờ
- Thanh toán và tạo hóa đơn
- Cập nhật thống kê khách hàng

### 3. Quản lý khách hàng
- Tự động tạo khách hàng mới
- Lưu lịch sử đặt sân
- Thống kê chi tiêu

### 4. Dashboard
- Thống kê doanh thu hôm nay
- Số đặt sân hôm nay
- Sân đang hoạt động
- Tổng khách hàng
- Danh sách đặt sân gần đây

## Ghi chú

- Các form detail còn lại có thể tạo tương tự như `FieldDetailForm` và `BookingDetailForm`
- Database schema đã đầy đủ, chỉ cần tạo UI cho các form còn lại
- Business logic đã được implement trong các form chính
- Cần thêm validation và error handling cho các form detail

## Tài khoản mặc định

- **Admin**: username=`admin`, password=`admin123`
- **Staff**: username=`staff01`, password=`admin123`

## Hỗ trợ

Nếu có vấn đề, vui lòng kiểm tra:
1. Database connection string
2. Database đã được tạo chưa
3. SQL Server đang chạy
4. User có quyền truy cập database

