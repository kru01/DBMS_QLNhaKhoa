﻿/* 21HTTT1 - Nhóm 3
 * 21127004 - Trần Nguyễn An Phong
 * 21127135 - Diệp Hữu Phúc
 * 21127149 - Huỳnh Minh Quang
 * 21127296 - Đặng Hà Huy
 */
USE [Nhom3_QLNhaKhoa]
GO

CREATE OR ALTER PROC USP_HSBA_INS
    @MAKHACHHANG VARCHAR(5),
    @MANHASHI VARCHAR(5),
    @MAHSBA VARCHAR(5) = NULL OUTPUT
AS BEGIN TRAN
    IF NOT EXISTS (SELECT * FROM KHACHHANG
        WHERE MAKHACHHANG = @MAKHACHHANG) BEGIN
        RAISERROR('INVALID MAKHACHHANG', 16, 1)
        ROLLBACK TRAN
        RETURN -1
    END

    IF NOT EXISTS (SELECT * FROM NHANVIEN WHERE MANHANVIEN = @MANHASHI) BEGIN
        RAISERROR('INVALID MANHASI', 16, 1)
        ROLLBACK TRAN
        RETURN -2
    END

    IF EXISTS (SELECT * FROM HOSOBENHAN
        WHERE MAKHACHHANG = @MAKHACHHANG AND MANHASI = @MANHASHI) BEGIN
        RAISERROR('HOSOBENHNHAN ALREADY EXISTS', 16, 1)
        ROLLBACK TRAN
        RETURN -3
    END

    SELECT @MAHSBA = MAHSBA FROM HOSOBENHAN
    WHERE MAHSBA = (SELECT MAX(MAHSBA) FROM HOSOBENHAN)

    SET @MAHSBA = dbo.F_MAKE_ID('HS', @MAHSBA)
    
    INSERT INTO HOSOBENHAN VALUES (@MAHSBA, @MAKHACHHANG, @MANHASHI)
COMMIT TRAN
RETURN 0
GO