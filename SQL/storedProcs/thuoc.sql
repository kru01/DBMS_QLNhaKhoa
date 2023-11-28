/* 21HTTT1 - Nhóm 3
 * 21127004 - Trần Nguyễn An Phong
 * 21127135 - Diệp Hữu Phúc
 * 21127149 - Huỳnh Minh Quang
 * 21127296 - Đặng Hà Huy
 */
USE [Nhom3_QLNhaKhoa]
GO

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

    IF NOT EXISTS (SELECT * FROM NHANVIEN WHERE MANHANVIEN = @MANVQUANLY) BEGIN
        RAISERROR('INVALID MANVQUANLY', 16, 1)
        ROLLBACK TRAN
        RETURN -5
    END

    SELECT @MATHUOC = MATHUOC FROM THUOC
    WHERE MATHUOC = (SELECT MAX(MATHUOC) FROM THUOC)

    SET @MATHUOC = dbo.F_MAKE_ID('TH', @MATHUOC)

    INSERT INTO THUOC
    VALUES (@MATHUOC, @TENTHUOC, @DONVITINH, @CHIDINH,
        @SOLUONGTONKHO, @NGAYHETHAN, @GIATIEN, @MANVQUANLY)
COMMIT TRAN
RETURN 0
GO

CREATE OR ALTER PROC USP_THUOC_UPD
    @MATHUOC VARCHAR(5),
    @TENTHUOC NVARCHAR(25),
    @DONVITINH NVARCHAR(5),
    @CHIDINH NVARCHAR(50),
    @SOLUONGTONKHO INT,
    @NGAYHETHAN DATE,
    @GIATIEN INT,
    @MANVQUANLY VARCHAR(5),
    @NGUOIUPDATE VARCHAR(5)
AS BEGIN TRAN
    IF NOT EXISTS (SELECT * FROM THUOC WHERE MATHUOC = @MATHUOC) BEGIN
        RAISERROR('INVALID MATHUOC', 16, 1)
        ROLLBACK TRAN
        RETURN -1
    END

    IF @DONVITINH != N'VIÊN' AND @DONVITINH != N'GÓI'
        AND @DONVITINH != N'HỘP' BEGIN
        RAISERROR(N'INVALID DONVITINH, MUST BE EITHER VIÊN, HỘP, OR GÓI', 16, 1)
        ROLLBACK TRAN
        RETURN -2
    END

    IF @SOLUONGTONKHO < 0 BEGIN
        RAISERROR('INVALID SOLUONGTONKHO', 16, 1)
        ROLLBACK TRAN
        RETURN -3
    END

    IF @GIATIEN < 0 BEGIN
        RAISERROR('INVALID GIATIEN', 16, 1)
        ROLLBACK TRAN
        RETURN -4
    END

    IF @TENTHUOC IS NULL OR @CHIDINH IS NULL OR @NGAYHETHAN IS NULL
        OR @NGUOIUPDATE IS NULL BEGIN
        RAISERROR('INVALID DATA', 16, 1)
        ROLLBACK TRAN
        RETURN -5
    END

    IF @NGUOIUPDATE NOT LIKE 'AD%' OR @NGUOIUPDATE != @MANVQUANLY BEGIN
        RAISERROR('ONLY ADMIN MANAGING THIS THUOC CAN UPDATE IT', 16, 1)
        ROLLBACK TRAN
        RETURN -6
    END

    UPDATE THUOC SET TENTHUOC = @TENTHUOC, DONVITINH = @DONVITINH,
        CHIDINH = @CHIDINH, SOLUONGTONKHO = @SOLUONGTONKHO,
        NGAYHETHAN = @NGAYHETHAN, GIATIEN = @GIATIEN,
        MANVQUANLY = @MANVQUANLY
    WHERE MATHUOC = @MATHUOC
COMMIT TRAN
RETURN 0
GO

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

--UPDATE ĐẨY HÀNG CHO NHỮNG NHÀ THUỐC KHÁC BỚT NHỮNG LOẠI THUỐC CÒN DƯỚI 6 THÁNG HOẶC TỪ 6 THÁNG TỚI 1 NĂM NỮA SẼ HẾT HẠN
CREATE OR ALTER PROC USP_THUOC_UPDATE_DAYHANG
    @NGUOIUPDATE VARCHAR(5)
AS SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
BEGIN TRAN

    IF @NGUOIUPDATE NOT LIKE 'AD%' BEGIN
            RAISERROR('ONLY ADMIN MANAGING THIS THUOC CAN UPDATE IT', 16, 1)
            ROLLBACK TRAN
            RETURN -1
        END

    UPDATE THUOC
    SET SOLUONGTONKHO = (SOLUONGTONKHO *  0.5)
    WHERE DATEDIFF(MONTH, GETDATE(), NGAYHETHAN) <= 6

    WAITFOR DELAY '00:00:10'

    UPDATE THUOC
    SET SOLUONGTONKHO = (SOLUONGTONKHO * 0.75)
    WHERE (DATEDIFF(MONTH, GETDATE(), NGAYHETHAN) > 6 AND DATEDIFF(MONTH, GETDATE(), NGAYHETHAN) <= 12)

COMMIT TRAN
RETURN 0
GO
GO

--UPDATE GIẢM GIÁ CHO NHỮNG LOẠI THUỐC CÒN 6 THÁNG HOẶC TỪ 6 THÁNG TỚI 1 NĂM NỮA SẼ HẾT HẠN
CREATE OR ALTER PROC USP_THUOC_UPDATE_GIAMGIA
    @NGUOIUPDATE VARCHAR(5)
AS SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
BEGIN TRAN

    IF @NGUOIUPDATE NOT LIKE 'AD%' BEGIN
            RAISERROR('ONLY ADMIN MANAGING THIS THUOC CAN UPDATE IT', 16, 1)
            ROLLBACK TRAN
            RETURN -1
        END


    UPDATE THUOC
    SET GIATIEN = (GIATIEN * 0.75)
    WHERE (DATEDIFF(MONTH, GETDATE(), NGAYHETHAN) > 6 AND DATEDIFF(MONTH, GETDATE(), NGAYHETHAN) <= 12)

    WAITFOR DELAY '00:00:10'


	UPDATE THUOC
    SET GIATIEN = (GIATIEN * 0.4)
    WHERE DATEDIFF(MONTH, GETDATE(), NGAYHETHAN) <= 6

COMMIT TRAN
RETURN 0
GO