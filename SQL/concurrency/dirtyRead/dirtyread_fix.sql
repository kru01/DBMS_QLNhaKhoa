/* 21HTTT1 - Nhóm 3
 * 21127004 - Trần Nguyễn An Phong
 * 21127135 - Diệp Hữu Phúc
 * 21127149 - Huỳnh Minh Quang
 * 21127296 - Đặng Hà Huy
 */
USE [Nhom3_QLNhaKhoa]
GO

-- TRAN 1
CREATE OR ALTER PROC USP_THUOC_INS
    @TENTHUOC NVARCHAR(25),
    @DONVITINH NVARCHAR(5),
    @CHIDINH NVARCHAR(50),
    @SOLUONGTONKHO INT,
    @NGAYHETHAN DATE,
    @GIATIEN INT,
    @MANVQUANLY VARCHAR(5),
    @MATHUOC VARCHAR(5) = NULL OUTPUT
AS BEGIN TRAN
    IF @DONVITINH != N'VIÊN' AND @DONVITINH != N'GÓI'
        AND @DONVITINH != N'HỘP' BEGIN
        RAISERROR(N'INVALID DONVITINH, MUST BE EITHER VIÊN, HỘP, OR GÓI', 16, 1)
        ROLLBACK TRAN
        RETURN -1
    END

    IF @SOLUONGTONKHO < 0 BEGIN
        RAISERROR('INVALID SOLUONGTONKHO', 16, 1)
        ROLLBACK TRAN
        RETURN -2
    END

    IF @GIATIEN < 0 BEGIN
        RAISERROR('INVALID GIATIEN', 16, 1)
        ROLLBACK TRAN
        RETURN -3
    END

    IF LEFT(@MANVQUANLY, 2) != 'AD' BEGIN
        RAISERROR('NVQUANLY MUST BE AN ADMIN', 16, 1)
        ROLLBACK TRAN
        RETURN -4
    END

    SELECT @MATHUOC = MATHUOC FROM THUOC
    WHERE MATHUOC = (SELECT MAX(MATHUOC) FROM THUOC)

    SET @MATHUOC = dbo.F_MAKE_ID('TH', @MATHUOC)

    INSERT INTO THUOC
    VALUES (@MATHUOC, @TENTHUOC, @DONVITINH, @CHIDINH,
        @SOLUONGTONKHO, @NGAYHETHAN, @GIATIEN, @MANVQUANLY)
    
    WAITFOR DELAY '00:00:10'

    IF NOT EXISTS (SELECT * FROM NHANVIEN WHERE MANHANVIEN = @MANVQUANLY) BEGIN
        RAISERROR('INVALID MANVQUANLY', 16, 1)
        ROLLBACK TRAN
        RETURN -5
    END
COMMIT TRAN
RETURN 0
GO

-- TRAN 2
CREATE OR ALTER PROC USP_THUOC_SEARCH
    @MATHUOC VARCHAR(5) = NULL,
    @TENTHUOC NVARCHAR(25) = NULL,
    @DONVITINH NVARCHAR(5) = NULL,
    @CHIDINH NVARCHAR(50) = NULL,
    @SOLUONGTONKHO INT = NULL,
    @NGAYHETHAN DATE = NULL,
    @GIATIEN INT = NULL,
    @MANVQUANLY VARCHAR(5) = NULL
AS BEGIN TRAN
    DECLARE @SQL NVARCHAR(MAX)
    SET @SQL = N'SELECT * FROM THUOC WHERE 1 = 1'

    IF @MATHUOC IS NOT NULL
        SET @SQL += N' AND MATHUOC LIKE ''%''+@MATHUOC+''%'''
    IF @TENTHUOC IS NOT NULL
        SET @SQL += N' AND TENTHUOC LIKE ''%''+@TENTHUOC+''%'''
    IF @DONVITINH IS NOT NULL
        SET @SQL += N' AND DONVITINH LIKE ''%''+@DONVITINH+''%'''
    IF @CHIDINH IS NOT NULL
        SET @SQL += N' AND CHIDINH LIKE ''%''+@CHIDINH+''%'''
    IF @SOLUONGTONKHO IS NOT NULL
        SET @SQL += N' AND SOLUONGTONKHO <= @SOLUONGTONKHO'
    IF @NGAYHETHAN IS NOT NULL
        SET @SQL += N' AND NGAYHETHAN <= @NGAYHETHAN'
    IF @GIATIEN IS NOT NULL
        SET @SQL += N' AND GIATIEN <= GIATIEN'
    IF @MANVQUANLY IS NOT NULL
        SET @SQL += N' AND MANVQUANLY LIKE ''%''+@MANVQUANLY+''%'''

    EXEC sp_executesql @SQL,
        N'@MATHUOC VARCHAR(5), @TENTHUOC NVARCHAR(25),
        @DONVITINH NVARCHAR(5), @CHIDINH NVARCHAR(50),
        @SOLUONGTONKHO INT, @NGAYHETHAN DATE,
        @GIATIEN INT, @MANVQUANLY VARCHAR(5)',
        @MATHUOC, @TENTHUOC, @DONVITINH, @CHIDINH,
        @SOLUONGTONKHO, @NGAYHETHAN, @GIATIEN, @MANVQUANLY
COMMIT TRAN
RETURN 0
GO