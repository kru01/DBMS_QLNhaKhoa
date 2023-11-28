/* 21HTTT1 - Nhóm 3
 * 21127004 - Trần Nguyễn An Phong
 * 21127135 - Diệp Hữu Phúc
 * 21127149 - Huỳnh Minh Quang
 * 21127296 - Đặng Hà Huy
 */
USE [Nhom3_QLNhaKhoa]
GO

CREATE OR ALTER PROC USP_KHACHHANG_INS
    @HOTEN NVARCHAR(25),
    @NGAYSINH NVARCHAR(10),
    @DIACHI NVARCHAR(100),
    @SODT VARCHAR(11),
    @MATKHAU VARCHAR(20),
    @MAKHACHHANG VARCHAR(5) = NULL OUTPUT
AS BEGIN TRAN
    SELECT @MAKHACHHANG = MAKHACHHANG FROM KHACHHANG
    WHERE MAKHACHHANG = (SELECT MAX(MAKHACHHANG) FROM KHACHHANG)

    SET @MAKHACHHANG = dbo.F_MAKE_ID('KH', @MAKHACHHANG)

    INSERT INTO KHACHHANG
    VALUES (@MAKHACHHANG, @HOTEN, @NGAYSINH, @DIACHI, @SODT, @MATKHAU)
COMMIT TRAN
RETURN 0
GO

CREATE OR ALTER PROC USP_KHACHHANG_UPD
    @MAKHACHHANG VARCHAR(5),
    @HOTEN NVARCHAR(25),
    @NGAYSINH DATE,
    @DIACHI NVARCHAR(100),
    @SODT VARCHAR(11),
    @MATKHAU VARCHAR(20)
AS BEGIN TRAN
    IF NOT EXISTS (SELECT * FROM KHACHHANG
        WHERE MAKHACHHANG = @MAKHACHHANG) BEGIN
        RAISERROR('INVALID MAKHACHHANG', 16, 1)
        ROLLBACK TRAN
        RETURN -1
    END

    IF @HOTEN IS NULL OR @NGAYSINH IS NULL OR @DIACHI IS NULL
        OR @SODT IS NULL OR @MATKHAU IS NULL BEGIN
        RAISERROR('INVALID DATA', 16, 1)
        ROLLBACK TRAN
        RETURN -2
    END

    UPDATE KHACHHANG SET HOTEN = @HOTEN, NGAYSINH = @NGAYSINH,
        DIACHI = @DIACHI, SODT = @SODT, MATKHAU = @MATKHAU
    WHERE MAKHACHHANG = @MAKHACHHANG
COMMIT TRAN
RETURN 0
GO