CREATE DATABASE IF NOT EXISTS studentdb;
USE studentdb;

CREATE TABLE students (
    id INT PRIMARY KEY AUTO_INCREMENT,
    student_id VARCHAR(10),
    fullname VARCHAR(100),
    dob DATE,
    major VARCHAR(50)
);

INSERT INTO students (student_id, fullname, dob, major) VALUES
('SV001', 'Nguyễn Văn A', '2004-10-12', 'Computer Science'),
('SV002', 'Trần Thị B', '2004-02-20', 'Information Systems'),
('SV003', 'Lê Hoàng C', '2003-08-05', 'Cyber Security');
