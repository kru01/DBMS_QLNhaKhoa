/* 21HTTT1 - Nhóm 3
 * 21127004 - Trần Nguyễn An Phong
 * 21127135 - Diệp Hữu Phúc
 * 21127149 - Huỳnh Minh Quang
 * 21127296 - Đặng Hà Huy
 */
USE [Nhom3_QLNhaKhoa]
GO

-- TRAN 1, 2
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

    IF @TENTHUOC IS NULL OR @DONVITINH IS NULL OR @CHIDINH IS NULL
        OR @SOLUONGTONKHO IS NULL OR @NGAYHETHAN IS NULL
        OR @GIATIEN IS NULL OR @NGUOIUPDATE IS NULL BEGIN
        RAISERROR('INVALID DATA', 16, 1)
        ROLLBACK TRAN
        RETURN -2
    END

    IF @NGUOIUPDATE NOT LIKE 'AD%' OR @NGUOIUPDATE != @MANVQUANLY BEGIN
        RAISERROR('ONLY ADMIN MANAGING THIS THUOC CAN UPDATE IT', 16, 1)
        ROLLBACK TRAN
        RETURN -3
    END

    UPDATE THUOC SET TENTHUOC = @TENTHUOC, DONVITINH = @DONVITINH,
        CHIDINH = @CHIDINH, SOLUONGTONKHO += @SOLUONGTONKHO,
        NGAYHETHAN = @NGAYHETHAN, GIATIEN = @GIATIEN,
        MANVQUANLY = @MANVQUANLY
    WHERE MATHUOC = @MATHUOC

    WAITFOR DELAY '00:00:10'
COMMIT TRAN
RETURN 0
GO