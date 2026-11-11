-- Run the entire file in the database that already has the Packing Orders tables.
IF OBJECT_ID(N'dbo.ct_LenhDongGoi',N'U') IS NULL
    THROW 51222, N'Chọn đúng cơ sở dữ liệu đã cài chức năng đóng gói rồi chạy lại toàn bộ tệp SQL.', 1;

SET XACT_ABORT ON;
BEGIN TRY
    BEGIN TRANSACTION;

    IF OBJECT_ID(N'dbo.ct_LenhDongGoi_NguyenLieu',N'U') IS NULL
    BEGIN
        CREATE TABLE dbo.ct_LenhDongGoi_NguyenLieu
        (
            LOC_ID nvarchar(50) NOT NULL,
            OrderId uniqueidentifier NOT NULL,
            DetailId nvarchar(50) NOT NULL,
            StockId nvarchar(50) NOT NULL,
            Kg decimal(18,6) NOT NULL,
            CONSTRAINT PK_ct_LenhDongGoi_NguyenLieu PRIMARY KEY (LOC_ID,OrderId,DetailId),
            CONSTRAINT FK_ct_LenhDongGoi_NguyenLieu_Order FOREIGN KEY (LOC_ID,OrderId)
                REFERENCES dbo.ct_LenhDongGoi(LOC_ID,ID),
            CONSTRAINT CK_ct_LenhDongGoi_NguyenLieu_Kg CHECK (Kg>0)
        );
    END;

    INSERT dbo.ct_LenhDongGoi_NguyenLieu(LOC_ID,OrderId,DetailId,StockId,Kg)
    SELECT o.LOC_ID,o.ID,o.SourceDetail,o.SourceStock,o.SourceKg
    FROM dbo.ct_LenhDongGoi o
    WHERE NOT EXISTS (SELECT 1 FROM dbo.ct_LenhDongGoi_NguyenLieu s WHERE s.LOC_ID=o.LOC_ID AND s.OrderId=o.ID);

    -- Keep view compilation in this transaction and report the original error on failure.
    EXEC sys.sp_executesql N'CREATE OR ALTER VIEW dbo.v_LenhDongGoi_NguyenLieu
AS
SELECT s.LOC_ID,s.OrderId,s.StockId,s.Kg,p.MA AS Code,p.NAME AS Name,
       d.SOLUONG AS Quantity,d.TYLE_QD AS Ratio,
       COALESCE(u.NAME COLLATE DATABASE_DEFAULT,d.ID_DVT COLLATE DATABASE_DEFAULT) AS Unit,
       d.STT AS LineNumber,
       CASE WHEN d.ISGIAVONDATINH=1 AND d.GIAVON>=0
            THEN TRY_CONVERT(decimal(18,2),ROUND(d.SOLUONG*d.TYLE_QD*d.GIAVON,2)) END AS Cost
FROM dbo.ct_LenhDongGoi_NguyenLieu s
LEFT JOIN dbo.dm_HangHoa_Kho k ON k.LOC_ID=s.LOC_ID AND k.ID=s.StockId
LEFT JOIN dbo.dm_HangHoa p ON p.LOC_ID=k.LOC_ID AND p.ID=k.ID_HANGHOA
LEFT JOIN dbo.ct_PhieuXuat_ChiTiet d ON d.LOC_ID=s.LOC_ID AND d.ID=s.DetailId
LEFT JOIN dbo.dm_DonViTinh u ON u.LOC_ID=d.LOC_ID AND u.ID=d.ID_DVT;';

    COMMIT TRANSACTION;
END TRY
BEGIN CATCH
    IF XACT_STATE() <> 0 ROLLBACK TRANSACTION;
    THROW;
END CATCH;

SELECT DB_NAME() AS [CoSoDuLieu], N'Đã cập nhật bảng và view nguyên liệu đóng gói.' AS [KetQua];
