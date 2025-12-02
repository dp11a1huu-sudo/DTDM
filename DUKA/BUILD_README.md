# DUKA Football Management System - Build Guide

## 📋 Yêu cầu hệ thống

- **Visual Studio 2019/2022** với .NET Framework 4.8
- **SQL Server** (Express hoặc Developer Edition)
- **Windows 10/11**

## 🏗️ Cấu trúc Project

```
DUKA/
├── DTO/          # Data Transfer Objects
├── DAL/          # Data Access Layer
├── BUS/          # Business Logic Layer
├── GUI/          # Graphical User Interface
├── Database/     # SQL Scripts
└── DUKA.sln      # Solution File
```

## 🔧 Cài đặt và Chạy

### Bước 1: Thiết lập Database

1. Mở SQL Server Management Studio (SSMS)
2. Chạy script `Database\CREATE_DATABASE.sql`
3. Chạy script `Database\DUKA_Database_Schema.sql`

### Bước 2: Cấu hình Connection String

1. Mở file `DAL\ConfigHelper.cs`
2. Cập nhật connection string theo SQL Server của bạn:

```csharp
private static string connectionString = @"Server=YOUR_SERVER;
                                           Database=DUKA_FootballManagement;
                                           User Id=YOUR_USERNAME;
                                           Password=YOUR_PASSWORD;";
```

### Bước 3: Build Project

**Cách 1: Sử dụng Visual Studio**
1. Mở `DUKA.sln` trong Visual Studio
2. Build Solution (F6 hoặc Build → Build Solution)

**Cách 2: Sử dụng Build Script**
1. Chạy file `build.bat`
2. Script sẽ tự động build tất cả projects theo thứ tự

### Bước 4: Chạy Ứng dụng

1. Sau khi build thành công, chạy file `GUI\bin\Debug\GUI.exe`
2. Đăng nhập với tài khoản mặc định:
   - Username: `admin`
   - Password: `admin123`

## 🐛 Xử lý Lỗi Build

### Lỗi "GenerateResource task failed"
- Đây là lỗi phổ biến với .NET SDK mới
- Giải pháp: Sử dụng Visual Studio để build thay vì dotnet CLI

### Lỗi "Could not find type or namespace"
- Đảm bảo đã build theo thứ tự: DTO → DAL → BUS → GUI
- Kiểm tra references trong file .csproj

### Lỗi Database Connection
- Kiểm tra SQL Server đang chạy
- Xác nhận connection string đúng
- Đảm bảo database đã được tạo

## 📦 Dependencies

Project sử dụng các assemblies .NET Framework:
- System.Data
- System.Data.SqlClient
- System.Windows.Forms
- System.Windows.Forms.DataVisualization

## 🔄 Build Order

1. **DTO** - Data Transfer Objects (không phụ thuộc)
2. **DAL** - Data Access Layer (phụ thuộc DTO)
3. **BUS** - Business Logic Layer (phụ thuộc DTO, DAL)
4. **GUI** - User Interface (phụ thuộc DTO, BUS, DAL)

## 🚀 Production Deployment

1. Build với configuration `Release`
2. Copy các file .exe và .dll từ `bin\Release\`
3. Đảm bảo SQL Server production có database
4. Cập nhật connection string trong config

## 📞 Hỗ trợ

Nếu gặp vấn đề khi build:
1. Kiểm tra Visual Studio version
2. Đảm bảo .NET Framework 4.8 đã cài đặt
3. Xem Output window trong Visual Studio để debug lỗi
4. Liên hệ team development nếu cần hỗ trợ
