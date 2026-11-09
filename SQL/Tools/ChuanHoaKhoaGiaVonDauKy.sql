-- Run before 20261105_OpeningStockCost.sql on a database with an empty legacy opening table.
SET XACT_ABORT ON;
IF OBJECT_ID(N'dbo.ct_GiaVonDauKy', N'U') IS NULL RETURN;
IF COL_LENGTH(N'dbo.ct_GiaVonDauKy', N'ID_HANGHOAKHO') IS NOT NULL RETURN;
IF COL_LENGTH(N'dbo.ct_GiaVonDauKy', N'ID_HANGHOA') IS NULL
    THROW 51010, N'Cấu trúc bảng đầu kỳ khác dự kiến. Kiểm tra tên các cột.', 1;
BEGIN TRY
    BEGIN TRANSACTION;
    IF EXISTS (SELECT 1 FROM dbo.ct_GiaVonDauKy WITH (TABLOCKX,HOLDLOCK))
        THROW 51011, N'Bảng đã có dữ liệu. Cần đối chiếu kho của từng dòng đầu kỳ trước khi chuyển.', 1;
    EXEC sys.sp_rename N'dbo.ct_GiaVonDauKy.ID_HANGHOA', N'ID_HANGHOAKHO', N'COLUMN';
    COMMIT;
END TRY
BEGIN CATCH
    IF XACT_STATE() <> 0 ROLLBACK;
    THROW;
END CATCH;
