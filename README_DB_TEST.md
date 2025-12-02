 # 🗄️ TEST DATABASE CONNECTION - STUDENTDB

## 📋 Yêu cầu
- Python 3.x
- MariaDB container đang chạy (docker compose up -d relational-database-server)

## 🚀 Cách sử dụng

### Bước 1: Cài đặt MySQL Connector
```bash
pip install mysql-connector-python
```

### Bước 2: Chạy script test
```bash
python test_db_connection.py
```

### Bước 3: Kiểm tra kết quả
Script sẽ:
- ✅ Kết nối đến database studentdb
- 📊 Hiển thị thông tin server
- 📋 Liệt kê tables
- 👥 Hiển thị danh sách sinh viên
- 🔄 Thực hiện CRUD operations mẫu

## 📊 Kết quả mẫu
```
✅ Kết nối thành công đến MariaDB!
📊 Server version: 11.x.x-MariaDB
📋 Database hiện tại: studentdb
📋 Danh sách tables:
  - students
👥 Danh sách sinh viên trong studentdb:
ID | Student ID | Full Name | DOB | Major
------------------------------------------------------------
1 | SV001 | Nguyễn Văn A | 2004-10-12 | Computer Science
2 | SV002 | Trần Thị B | 2004-02-20 | Information Systems
3 | SV003 | Lê Hoàng C | 2003-08-05 | Cyber Security

🔄 THỰC HIỆN CRUD OPERATIONS:
➕ CREATE: Thêm sinh viên mới
✅ Đã thêm sinh viên SV004
📖 READ: Hiển thị sinh viên ngành Computer Science
  - SV001: Nguyễn Văn A
✏️ UPDATE: Cập nhật ngành học của SV004
✅ Đã cập nhật ngành của SV004
🗑️ DELETE: Xóa sinh viên SV004
✅ Đã xóa sinh viên SV004

🎉 Đã hoàn thành tất cả CRUD operations!
🔌 Đã đóng kết nối database.
```

## 🛠️ Xử lý lỗi

### Lỗi "ModuleNotFoundError: No module named 'mysql'"
```bash
pip install mysql-connector-python
```

### Lỗi kết nối database
```bash
# Kiểm tra container đang chạy
docker compose ps

# Kiểm tra logs
docker compose logs relational-database-server
```

### Lỗi port 3306 bị block
- Kiểm tra firewall Windows
- Đảm bảo không có ứng dụng khác sử dụng port 3306

## 📁 Files
- `test_db_connection.py` - Script test database connection
- `HUONG_DAN_CHI_TIET.txt` - Hướng dẫn chi tiết đầy đủ
