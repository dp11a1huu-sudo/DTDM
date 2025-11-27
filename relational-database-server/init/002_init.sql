-- Tạo database mới
CREATE DATABASE IF NOT EXISTS studentdemo;
USE studentdemo;

-- Tạo bảng students
CREATE TABLE IF NOT EXISTS students (
    id INT AUTO_INCREMENT PRIMARY KEY,
    student_id VARCHAR(10) NOT NULL,
    fullname VARCHAR(100) NOT NULL,
    dob DATE,
    major VARCHAR(50)
);

-- Chèn 3 sinh viên mẫu
INSERT INTO students(student_id, fullname, dob, major) VALUES 
('SV01', 'Bui Huong Giang', '2005-04-03', 'Cong nghe thong tin'),
('SV02', 'Pham Thi Thuy An', '2005-01-20', 'Mang tinh va truyen thong du lieu'),
('SV03', 'Nguyen Thi My Dung', '2005-09-03', 'An toan thong tin');