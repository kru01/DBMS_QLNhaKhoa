/* 21HTTT1 - Nhóm 3
 * 21127004 - Trần Nguyễn An Phong
 * 21127135 - Diệp Hữu Phúc
 * 21127149 - Huỳnh Minh Quang
 * 21127296 - Đặng Hà Huy
 */
USE [Nhom3_QLNhaKhoa]
GO

-- TRAN 1, 2
CREATE OR ALTER PROC USP_NHANVIEN_UPD
    @MANHANVIEN VARCHAR(5),
    @HOTEN NVARCHAR(25),
    @DIACHI NVARCHAR(100),
    @SODT VARCHAR(11),
    @LOAINHANVIEN INT, -- 0: NHANVIEN, 1: NHASI, 2: QUANTRIVIEN
    @MATKHAU VARCHAR(20)
AS BEGIN TRAN
    IF NOT EXISTS (SELECT * FROM NHANVIEN WHERE MANHANVIEN = @MANHANVIEN) BEGIN
        RAISERROR('INVALID MANHANVIEN', 16, 1)
        ROLLBACK TRAN
        RETURN -1
    END

    IF @LOAINHANVIEN != 0 AND @LOAINHANVIEN != 1 AND @LOAINHANVIEN != 2 BEGIN
        RAISERROR('INVALID LOAINHANVIEN', 16, 1)
        ROLLBACK TRAN
        RETURN -2
    END

    IF @HOTEN IS NULL OR @DIACHI IS NULL OR @SODT IS NULL
        OR @MATKHAU IS NULL BEGIN
        RAISERROR('INVALID DATA', 16, 1)
        ROLLBACK TRAN
        RETURN -3
    END

    WAITFOR DELAY '00:00:10'

    UPDATE NHANVIEN SET HOTEN = @HOTEN, DIACHI = @DIACHI, SODT = @SODT,
        LOAINHANVIEN = @LOAINHANVIEN, MATKHAU = @MATKHAU
    WHERE MANHANVIEN = @MANHANVIEN
COMMIT TRAN
RETURN 0
GO