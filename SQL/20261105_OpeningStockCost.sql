-- Run on the application database before deploying the API.
IF OBJECT_ID('dbo.ct_GiaVonDauKy', 'U') IS NULL
    CREATE TABLE dbo.ct_GiaVonDauKy (
        LOC_ID nvarchar(50) NOT NULL,
        ID_HANGHOAKHO nvarchar(50) NOT NULL,
        TUNGAY date NOT NULL,
        SOLUONG decimal(18,6) NOT NULL CHECK (SOLUONG >= 0),
        DONGIA decimal(18,6) NOT NULL CHECK (DONGIA >= 0),
        CONSTRAINT PK_ct_GiaVonDauKy PRIMARY KEY (LOC_ID, ID_HANGHOAKHO),
        CONSTRAINT CK_ct_GiaVonDauKy_Cost CHECK (SOLUONG = 0 OR DONGIA > 0)
    );
IF COL_LENGTH('dbo.ct_PhieuXuat_ChiTiet', 'ISGIAVONDATINH') IS NULL
    ALTER TABLE dbo.ct_PhieuXuat_ChiTiet ADD ISGIAVONDATINH bit NOT NULL
        CONSTRAINT DF_ct_PhieuXuat_CT_Costed DEFAULT (0);
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE object_id=OBJECT_ID('dbo.ct_PhieuNhap_ChiTiet') AND name='IX_GiaVon_NhapKho')
    CREATE INDEX IX_GiaVon_NhapKho ON dbo.ct_PhieuNhap_ChiTiet (LOC_ID, ID_HANGHOAKHO, ID_PHIEUNHAP);
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE object_id=OBJECT_ID('dbo.ct_PhieuXuat_ChiTiet') AND name='IX_GiaVon_XuatKho')
    CREATE INDEX IX_GiaVon_XuatKho ON dbo.ct_PhieuXuat_ChiTiet (LOC_ID, ID_HANGHOAKHO, ID_PHIEUXUAT);
GO
CREATE OR ALTER PROCEDURE dbo.TinhGiaVonHangKho
    @loc nvarchar(50), @stock nvarchar(50)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @start date, @balance decimal(28,6), @average decimal(28,10);
    SELECT @start=TUNGAY, @balance=SOLUONG, @average=DONGIA
    FROM dbo.ct_GiaVonDauKy WHERE LOC_ID=@loc AND ID_HANGHOAKHO=@stock;

    -- An edited voucher may have moved to another stock row or before the opening.
    UPDATE d SET GIAVON=0, ISGIAVONDATINH=0
    FROM dbo.ct_PhieuXuat_ChiTiet d JOIN dbo.ct_PhieuXuat h ON h.LOC_ID=d.LOC_ID AND h.ID=d.ID_PHIEUXUAT
    WHERE d.LOC_ID=@loc AND d.ID_HANGHOAKHO=@stock AND d.ISGIAVONDATINH=1
        AND (@start IS NULL OR h.NGAYLAP < @start OR d.SOLUONG=0);
    IF @start IS NULL RETURN;

    DECLARE @hasCost bit=CASE WHEN @balance>0 OR @average>0 THEN 1 ELSE 0 END;
    DECLARE @id nvarchar(50), @kind int, @qty decimal(28,6), @ratio decimal(18,6),
        @net decimal(28,6), @original nvarchar(50), @returnCost decimal(28,10);
    -- GIAVON is always per smallest stock unit. Line cost = SOLUONG * TYLE_QD * GIAVON.
    DECLARE @costs TABLE (ID nvarchar(50) PRIMARY KEY, StockCost decimal(28,10));
    DECLARE movements CURSOR LOCAL FAST_FORWARD FOR
        SELECT ID, Kind, Qty, Ratio, Net, Original FROM (
            SELECT d.ID, CASE WHEN t.ISNHAPTRAHANG=1 THEN 1 ELSE 0 END Kind,
                d.SOLUONG*d.TYLE_QD Qty, d.TYLE_QD Ratio, d.THANHTIEN Net,
                d.ID_PHIEUXUAT_CHITIET Original, h.NGAYLAP Stamp, h.SOPHIEU Seq
            FROM dbo.ct_PhieuNhap_ChiTiet d JOIN dbo.ct_PhieuNhap h ON h.LOC_ID=d.LOC_ID AND h.ID=d.ID_PHIEUNHAP
            LEFT JOIN dbo.dm_LoaiPhieuNhap t ON t.LOC_ID=h.LOC_ID AND t.ID=h.ID_LOAIPHIEUNHAP
            WHERE d.LOC_ID=@loc AND d.ID_HANGHOAKHO=@stock AND h.NGAYLAP>=@start AND d.SOLUONG<>0
            UNION ALL
            SELECT d.ID, 2, d.SOLUONG*d.TYLE_QD, d.TYLE_QD, 0, NULL, h.NGAYLAP, h.SOPHIEU
            FROM dbo.ct_PhieuXuat_ChiTiet d JOIN dbo.ct_PhieuXuat h ON h.LOC_ID=d.LOC_ID AND h.ID=d.ID_PHIEUXUAT
            WHERE d.LOC_ID=@loc AND d.ID_HANGHOAKHO=@stock AND h.NGAYLAP>=@start AND d.SOLUONG<>0
        ) m ORDER BY Stamp, Kind, Seq, ID;
    OPEN movements;
    FETCH NEXT FROM movements INTO @id,@kind,@qty,@ratio,@net,@original;
    WHILE @@FETCH_STATUS=0
    BEGIN
        IF @qty<=0 OR @ratio<=0 THROW 51101, N'Số lượng hoặc tỷ lệ quy đổi trên phiếu không hợp lệ.', 1;
        IF @kind=2
        BEGIN
            IF @qty>@balance THROW 51102, N'Số lượng xuất vượt tồn tính vốn. Kiểm tra số lượng đầu kỳ và ngày phiếu.', 1;
            INSERT INTO @costs VALUES (@id, @average);
            SET @balance-=@qty;
        END
        ELSE
        BEGIN
            IF @kind=1
            BEGIN
                -- Customer returns use the original cost when available, never the selling price.
                SET @returnCost=COALESCE((SELECT StockCost FROM @costs WHERE ID=@original),
                    CASE WHEN @hasCost=1 THEN @average END);
                IF @returnCost IS NULL THROW 51103, N'Chưa có giá vốn để nhận hàng khách trả. Kiểm tra đơn giá đầu kỳ.', 1;
                SET @net=@returnCost*@qty;
            END;
            IF @net<0 THROW 51103, N'Trị giá nhập sau chiết khấu không hợp lệ.', 1;
            SET @average=(CAST(@balance*@average+@net AS decimal(28,8)) / CAST(@balance+@qty AS decimal(20,6)));
            SET @balance+=@qty;
            SET @hasCost=1;
        END;
        FETCH NEXT FROM movements INTO @id,@kind,@qty,@ratio,@net,@original;
    END;
    CLOSE movements;
    DEALLOCATE movements;
    UPDATE d SET GIAVON=c.StockCost, ISGIAVONDATINH=1
    FROM dbo.ct_PhieuXuat_ChiTiet d JOIN @costs c ON c.ID=d.ID
    WHERE d.LOC_ID=@loc AND d.ID_HANGHOAKHO=@stock AND (d.ISGIAVONDATINH=0 OR d.GIAVON<>CONVERT(float,c.StockCost));
END;
GO
-- Refresh previously calculated voucher-unit prices from the ledger. Safe to rerun.
SET XACT_ABORT ON;
DECLARE @loc nvarchar(50), @stock nvarchar(50), @locked nvarchar(50);
DECLARE seeded CURSOR LOCAL STATIC READ_ONLY FOR
    SELECT o.LOC_ID,o.ID_HANGHOAKHO FROM dbo.ct_GiaVonDauKy o
    WHERE EXISTS (SELECT 1 FROM dbo.ct_PhieuXuat_ChiTiet d WHERE d.LOC_ID=o.LOC_ID
        AND d.ID_HANGHOAKHO=o.ID_HANGHOAKHO AND d.ISGIAVONDATINH=1 AND d.TYLE_QD<>1)
    ORDER BY o.LOC_ID,o.ID_HANGHOAKHO;
OPEN seeded;
FETCH NEXT FROM seeded INTO @loc,@stock;
WHILE @@FETCH_STATUS=0
BEGIN
    BEGIN TRANSACTION;
    SELECT @locked=ID FROM dbo.dm_HangHoa_Kho WITH (UPDLOCK,HOLDLOCK) WHERE LOC_ID=@loc AND ID=@stock;
    EXEC dbo.TinhGiaVonHangKho @loc,@stock;
    COMMIT;
    FETCH NEXT FROM seeded INTO @loc,@stock;
END;
CLOSE seeded;
DEALLOCATE seeded;
GO
