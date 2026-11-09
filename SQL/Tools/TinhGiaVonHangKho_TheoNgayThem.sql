-- Chỉ cập nhật thủ tục; không tự chạy lại giá vốn.
-- THOIGIANTHEM chỉ lấy ngày. Cùng ngày: nhập, khách trả, xuất; sau đó SOPHIEU và ID.
-- Các thủ tục gọi/kiểm tra phải dùng cùng mốc ngày THOIGIANTHEM.
USE [dbTrangHiepPhat]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
        AND (@start IS NULL OR CONVERT(date, h.THOIGIANTHEM) < @start OR d.SOLUONG=0);
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
                d.ID_PHIEUXUAT_CHITIET Original, CONVERT(date, h.THOIGIANTHEM) Stamp, h.SOPHIEU Seq
            FROM dbo.ct_PhieuNhap_ChiTiet d JOIN dbo.ct_PhieuNhap h ON h.LOC_ID=d.LOC_ID AND h.ID=d.ID_PHIEUNHAP
            LEFT JOIN dbo.dm_LoaiPhieuNhap t ON t.LOC_ID=h.LOC_ID AND t.ID=h.ID_LOAIPHIEUNHAP
            WHERE d.LOC_ID=@loc AND d.ID_HANGHOAKHO=@stock AND CONVERT(date, h.THOIGIANTHEM)>=@start AND d.SOLUONG<>0
            UNION ALL
            SELECT d.ID, 2, d.SOLUONG*d.TYLE_QD, d.TYLE_QD, 0, NULL, CONVERT(date, h.THOIGIANTHEM), h.SOPHIEU
            FROM dbo.ct_PhieuXuat_ChiTiet d JOIN dbo.ct_PhieuXuat h ON h.LOC_ID=d.LOC_ID AND h.ID=d.ID_PHIEUXUAT
            WHERE d.LOC_ID=@loc AND d.ID_HANGHOAKHO=@stock AND CONVERT(date, h.THOIGIANTHEM)>=@start AND d.SOLUONG<>0
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
