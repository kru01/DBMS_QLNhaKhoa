/* 21HTTT1 - Nhóm 3
 * 21127004 - Trần Nguyễn An Phong
 * 21127135 - Diệp Hữu Phúc
 * 21127149 - Huỳnh Minh Quang
 * 21127296 - Đặng Hà Huy
 */
USE [Nhom3_QLNhaKhoa]
GO

SELECT * FROM THUOC

DECLARE @ERR INT

EXEC @ERR = USP_THUOC_INS N'ABC', N'Gói', N'Uống trước khi ăn',
    10, '2025/01/01', 10000, 'AD001'

IF @ERR != 0 PRINT('INSERTION FAILED!')
ELSE PRINT('INSERTION SUCCESSFUL!')

SELECT * FROM THUOC