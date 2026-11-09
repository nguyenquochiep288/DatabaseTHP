-- Chon database nghiep vu trong SSMS. File nay CHI tao thu tuc, khong tu chay tinh von.
-- Can cai dat 20261105_OpeningStockCost.sql truoc.
-- GIAVON theo don vi ton nho nhat; thanh tien von = SOLUONG * TYLE_QD * GIAVON.
-- Hang da co dau ky: giu nguyen moc va so du dau ky.
-- Hang chua co dau ky: chi khoi tao 0 khi @XacNhanTonDauBang0=1.
-- Chi dung xac nhan nay neu lich su day du va thuc su khong co ton truoc phieu dau tien.
GO
CREATE OR ALTER PROCEDURE dbo.TinhGiaVonTuDauDenCuoi
    @LOC_ID nvarchar(50),
    @ID_KHO nvarchar(50) = NULL,
    @ID_HANGHOAKHO nvarchar(50) = NULL,
    @XacNhanTonDauBang0 bit = 0
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;
    IF @@TRANCOUNT <> 0
        THROW 51210, N'Chạy thủ tục ngoài transaction khác; mỗi mặt hàng được lưu trong transaction riêng.', 1;
    IF NULLIF(LTRIM(RTRIM(@LOC_ID)), N'') IS NULL
        THROW 51211, N'Phải chọn LOC_ID chi nhánh cần tính.', 1;
    IF OBJECT_ID(N'dbo.TinhGiaVonHangKho', N'P') IS NULL
        OR COL_LENGTH(N'dbo.ct_GiaVonDauKy', N'ID_HANGHOAKHO') IS NULL
        THROW 51212, N'Cần cài đặt script giá vốn đầu kỳ đúng cấu trúc trước.', 1;

    DECLARE @stock nvarchar(50), @kho nvarchar(50), @locked nvarchar(50),
        @start date, @created bit, @lines int, @message nvarchar(4000);
    CREATE TABLE #KetQua (
        LOC_ID nvarchar(50), ID_KHO nvarchar(50), ID_HANGHOAKHO nvarchar(50),
        TUNGAY date NULL, TAO_DAUKY_0 bit, SO_DONG_XUAT int,
        TRANGTHAI nvarchar(30), LYDO nvarchar(4000)
    );
    DECLARE items CURSOR LOCAL STATIC READ_ONLY FOR
        SELECT ID, ID_KHO FROM dbo.dm_HangHoa_Kho
        WHERE LOC_ID=@LOC_ID
          AND (@ID_KHO IS NULL OR ID_KHO=@ID_KHO)
          AND (@ID_HANGHOAKHO IS NULL OR ID=@ID_HANGHOAKHO)
        ORDER BY ID;
    OPEN items;
    FETCH NEXT FROM items INTO @stock,@kho;
    WHILE @@FETCH_STATUS=0
    BEGIN
        SELECT @start=NULL, @created=0, @lines=0, @locked=NULL;
        BEGIN TRY
            BEGIN TRANSACTION;
            SELECT @locked=ID FROM dbo.dm_HangHoa_Kho WITH (UPDLOCK,HOLDLOCK)
                WHERE LOC_ID=@LOC_ID AND ID=@stock;
            IF @locked IS NULL THROW 51104, N'Hàng tại kho không còn tồn tại.', 1;
            SELECT @start=TUNGAY FROM dbo.ct_GiaVonDauKy WITH (UPDLOCK,HOLDLOCK)
                WHERE LOC_ID=@LOC_ID AND ID_HANGHOAKHO=@stock;
            IF @start IS NULL
            BEGIN
                IF ISNULL(@XacNhanTonDauBang0,0)<>1
                    THROW 51105, N'Chưa có đầu kỳ. Cần khai báo hoặc xác nhận tồn trước lịch sử bằng 0.', 1;
                SELECT @start=CONVERT(date,MIN(NGAYLAP)) FROM (
                    SELECT h.NGAYLAP FROM dbo.ct_PhieuNhap_ChiTiet d
                    JOIN dbo.ct_PhieuNhap h ON h.LOC_ID=d.LOC_ID AND h.ID=d.ID_PHIEUNHAP
                    WHERE d.LOC_ID=@LOC_ID AND d.ID_HANGHOAKHO=@stock AND d.SOLUONG<>0
                    UNION ALL
                    SELECT h.NGAYLAP FROM dbo.ct_PhieuXuat_ChiTiet d
                    JOIN dbo.ct_PhieuXuat h ON h.LOC_ID=d.LOC_ID AND h.ID=d.ID_PHIEUXUAT
                    WHERE d.LOC_ID=@LOC_ID AND d.ID_HANGHOAKHO=@stock AND d.SOLUONG<>0
                ) m;
                IF @start IS NULL THROW 51106, N'Không có phát sinh nhập xuất để tính giá vốn.', 1;
                INSERT dbo.ct_GiaVonDauKy(LOC_ID,ID_HANGHOAKHO,TUNGAY,SOLUONG,DONGIA)
                    VALUES (@LOC_ID,@stock,@start,0,0);
                SET @created=1;
            END;

            -- Khong de NULL tren du lieu cu am tham tao gia von NULL.
            IF EXISTS (
                SELECT 1 FROM dbo.ct_PhieuNhap_ChiTiet d
                JOIN dbo.ct_PhieuNhap h ON h.LOC_ID=d.LOC_ID AND h.ID=d.ID_PHIEUNHAP
                WHERE d.LOC_ID=@LOC_ID AND d.ID_HANGHOAKHO=@stock
                  AND (h.NGAYLAP IS NULL OR (h.NGAYLAP>=@start AND
                    (d.SOLUONG IS NULL OR (d.SOLUONG<>0 AND (d.TYLE_QD IS NULL OR d.THANHTIEN IS NULL)))))
                UNION ALL
                SELECT 1 FROM dbo.ct_PhieuXuat_ChiTiet d
                JOIN dbo.ct_PhieuXuat h ON h.LOC_ID=d.LOC_ID AND h.ID=d.ID_PHIEUXUAT
                WHERE d.LOC_ID=@LOC_ID AND d.ID_HANGHOAKHO=@stock
                  AND (h.NGAYLAP IS NULL OR (h.NGAYLAP>=@start AND
                    (d.SOLUONG IS NULL OR (d.SOLUONG<>0 AND d.TYLE_QD IS NULL))))
            ) THROW 51107, N'Phiếu thiếu ngày, số lượng, tỷ lệ quy đổi hoặc thành tiền nhập. Cần kiểm tra dữ liệu.', 1;

            EXEC dbo.TinhGiaVonHangKho @loc=@LOC_ID,@stock=@stock;
            SELECT @lines=COUNT(*) FROM dbo.ct_PhieuXuat_ChiTiet d
            JOIN dbo.ct_PhieuXuat h ON h.LOC_ID=d.LOC_ID AND h.ID=d.ID_PHIEUXUAT
            WHERE d.LOC_ID=@LOC_ID AND d.ID_HANGHOAKHO=@stock
                AND h.NGAYLAP>=@start AND d.SOLUONG<>0 AND d.ISGIAVONDATINH=1;
            COMMIT;
            INSERT #KetQua VALUES(@LOC_ID,@kho,@stock,@start,@created,@lines,
                N'Đã tính',CASE WHEN @created=1 THEN N'Đã tạo đầu kỳ 0 từ ngày phát sinh đầu tiên.'
                    ELSE N'Tính lại từ mốc đầu kỳ đã khai báo.' END);
        END TRY
        BEGIN CATCH
            SET @message=ERROR_MESSAGE();
            IF XACT_STATE()<>0 ROLLBACK;
            -- Loi nghiep vu: ghi nhan tung hang. Loi he thong: dung va tra loi goc.
            IF ERROR_NUMBER() NOT BETWEEN 51101 AND 51107 THROW;
            INSERT #KetQua VALUES(@LOC_ID,@kho,@stock,@start,0,0,N'Chưa tính',@message);
        END CATCH;
        FETCH NEXT FROM items INTO @stock,@kho;
    END;
    CLOSE items;
    DEALLOCATE items;
    SELECT COUNT(*) AS SO_HANG_KHO,
        COALESCE(SUM(CASE WHEN TRANGTHAI=N'Đã tính' THEN 1 ELSE 0 END),0) AS DA_TINH,
        COALESCE(SUM(CASE WHEN TRANGTHAI=N'Chưa tính' THEN 1 ELSE 0 END),0) AS CHUA_TINH,
        COALESCE(SUM(SO_DONG_XUAT),0) AS SO_DONG_XUAT FROM #KetQua;
    SELECT * FROM #KetQua ORDER BY TRANGTHAI,ID_KHO,ID_HANGHOAKHO;
END;
GO
/* Cach chay (thay ID thuc te):
-- Thu mot hang, lich su day du, ton truoc phieu dau tien = 0:
EXEC dbo.TinhGiaVonTuDauDenCuoi
    @LOC_ID=N'ID_CHI_NHANH', @ID_KHO=N'ID_KHO',
    @ID_HANGHOAKHO=N'ID_HANG_HOA_KHO', @XacNhanTonDauBang0=1;

-- Tat ca hang trong mot kho (bo tham so ID_HANGHOAKHO):
EXEC dbo.TinhGiaVonTuDauDenCuoi
    @LOC_ID=N'ID_CHI_NHANH', @ID_KHO=N'ID_KHO', @XacNhanTonDauBang0=1;
-- De @ID_KHO=NULL de chay moi kho thuoc chi nhanh da chon.
-- Mac dinh @XacNhanTonDauBang0=0: khong tu tao dau ky, bao thieu tren tung hang.
*/
