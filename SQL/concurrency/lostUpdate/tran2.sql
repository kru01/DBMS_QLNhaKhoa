/* 21HTTT1 - Nhóm 3
 * 21127004 - Trần Nguyễn An Phong
 * 21127135 - Diệp Hữu Phúc
 * 21127149 - Huỳnh Minh Quang
 * 21127296 - Đặng Hà Huy
 */
USE [Nhom3_QLNhaKhoa]
GO

SELECT * FROM TOATHUOC WHERE MATHUOC = 'TH009'

DECLARE @ERR INT

EXEC @ERR = USP_TOATHUOC_UPD 'HS001', 'GK001', 'TH009', 20

IF @ERR != 0 PRINT('UPDATE FAILED!')
ELSE PRINT('UPDATE SUCCESSFUL!')

SELECT * FROM TOATHUOC WHERE MATHUOC = 'TH009'