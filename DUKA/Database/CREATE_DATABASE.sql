-- =============================================
-- Script tạo database DUKA_FootballManagement
-- Chạy script này trước khi chạy DUKA_Database_Schema.sql
-- =============================================

-- Kiểm tra và tạo database
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'DUKA_FootballManagement')
BEGIN
    CREATE DATABASE DUKA_FootballManagement;
    PRINT 'Database DUKA_FootballManagement đã được tạo thành công!';
END
ELSE
BEGIN
    PRINT 'Database DUKA_FootballManagement đã tồn tại.';
END
GO

-- Kiểm tra database đã được tạo
USE [DUKA_FootballManagement]
GO

PRINT 'Đã chuyển sang database DUKA_FootballManagement.';
PRINT 'Bây giờ bạn có thể chạy file DUKA_Database_Schema.sql để tạo các bảng.';
GO

