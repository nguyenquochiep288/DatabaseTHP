-- Chon database nghiep vu. Chi tao thu tuc chan doan; khong sua du lieu hay GIAVON.
GO
CREATE OR ALTER PROCEDURE dbo.KiemTraThuTuNhapXuat
    @LOC_ID nvarchar(50),
    @ID_HANGHOAKHO nvarchar(50),
    @ChiHienLoi bit = 1
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS(SELECT 1 FROM dbo.dm_HangHoa_Kho WHERE LOC_ID=@LOC_ID AND ID=@ID_HANGHOAKHO)
        THROW 51220,N'Không tìm thấy hàng tại kho trong chi nhánh đã chọn.',1;
    DECLARE @start date,@opening decimal(28,6)=0;
    SELECT @start=TUNGAY,@opening=SOLUONG FROM dbo.ct_GiaVonDauKy
        WHERE LOC_ID=@LOC_ID AND ID_HANGHOAKHO=@ID_HANGHOAKHO;
    ;WITH Movements AS (
        SELECT d.ID AS ID_CHITIET,d.ID_PHIEUNHAP AS ID_PHIEU,h.ID AS HEADER_ID,
            h.MAPHIEU,h.SOPHIEU,h.NGAYLAP,h.THOIGIANTHEM,
            CASE WHEN t.ISNHAPTRAHANG=1 THEN 1 ELSE 0 END AS KIND,
            d.SOLUONG,d.TYLE_QD
        FROM dbo.ct_PhieuNhap_ChiTiet d
        LEFT JOIN dbo.ct_PhieuNhap h ON h.LOC_ID=d.LOC_ID AND h.ID=d.ID_PHIEUNHAP
        LEFT JOIN dbo.dm_LoaiPhieuNhap t ON t.LOC_ID=h.LOC_ID AND t.ID=h.ID_LOAIPHIEUNHAP
        WHERE d.LOC_ID=@LOC_ID AND d.ID_HANGHOAKHO=@ID_HANGHOAKHO
            AND (d.SOLUONG IS NULL OR d.SOLUONG<>0)
        UNION ALL
        SELECT d.ID,d.ID_PHIEUXUAT,h.ID,h.MAPHIEU,h.SOPHIEU,h.NGAYLAP,h.THOIGIANTHEM,2,d.SOLUONG,d.TYLE_QD
        FROM dbo.ct_PhieuXuat_ChiTiet d
        LEFT JOIN dbo.ct_PhieuXuat h ON h.LOC_ID=d.LOC_ID AND h.ID=d.ID_PHIEUXUAT
        WHERE d.LOC_ID=@LOC_ID AND d.ID_HANGHOAKHO=@ID_HANGHOAKHO
            AND (d.SOLUONG IS NULL OR d.SOLUONG<>0)
    ), Checked AS (
        SELECT *,CONVERT(date,THOIGIANTHEM) AS NGAY_TINH,
            TRY_CONVERT(decimal(28,6),SOLUONG*TYLE_QD) AS SL_NHO,
            CASE WHEN HEADER_ID IS NULL THEN N'Thiếu phiếu cha'
                WHEN THOIGIANTHEM IS NULL THEN N'Thiếu THOIGIANTHEM'
                WHEN SOLUONG IS NULL OR SOLUONG<0 THEN N'Số lượng không hợp lệ'
                WHEN TYLE_QD IS NULL OR TYLE_QD<=0 OR TRY_CONVERT(decimal(18,6),TYLE_QD) IS NULL
                    OR TRY_CONVERT(decimal(18,6),TYLE_QD)<=0 THEN N'Tỷ lệ quy đổi không hợp lệ'
                WHEN TRY_CONVERT(decimal(28,6),SOLUONG*TYLE_QD) IS NULL
                    OR TRY_CONVERT(decimal(28,6),SOLUONG*TYLE_QD)<=0 THEN N'Số lượng quy đổi không hợp lệ'
            END AS LOI_DULIEU
        FROM Movements
        WHERE @start IS NULL OR THOIGIANTHEM IS NULL OR CONVERT(date,THOIGIANTHEM)>=@start
    ), Ledger AS (
        SELECT *,
            ROW_NUMBER() OVER(ORDER BY NGAY_TINH,KIND,SOPHIEU,ID_CHITIET) AS THUTU,
            SUM(CASE WHEN LOI_DULIEU IS NOT NULL THEN 1 ELSE 0 END) OVER() AS SO_DONG_LOI,
            @opening+SUM(CASE WHEN LOI_DULIEU IS NOT NULL THEN 0 WHEN KIND=2 THEN -SL_NHO ELSE SL_NHO END)
                OVER(ORDER BY NGAY_TINH,KIND,SOPHIEU,ID_CHITIET ROWS UNBOUNDED PRECEDING) AS TON_SAU
        FROM Checked
    ), Marked AS (
        SELECT *,MIN(CASE WHEN SO_DONG_LOI=0 AND KIND=2 AND TON_SAU<0 THEN THUTU END) OVER() AS AM_DAUTIEN
        FROM Ledger
    )
    SELECT THUTU,
        CASE KIND WHEN 0 THEN N'Nhập' WHEN 1 THEN N'Nhập khách trả' ELSE N'Xuất' END AS LOAI_PHIEU,
        MAPHIEU,SOPHIEU,NGAY_TINH,THOIGIANTHEM,NGAYLAP,SOLUONG,TYLE_QD,SL_NHO,
        @start AS TINH_TU_DAUKY,@opening AS TON_DAUKY,
        CASE WHEN SO_DONG_LOI=0 THEN TON_SAU-CASE WHEN KIND=2 THEN -SL_NHO ELSE SL_NHO END END AS TON_TRUOC,
        CASE WHEN SO_DONG_LOI=0 THEN TON_SAU END AS TON_SAU,
        CASE WHEN SO_DONG_LOI=0 AND KIND=2 AND TON_SAU<0 THEN -TON_SAU END AS SL_THIEU,
        CONVERT(bit,CASE WHEN THUTU=AM_DAUTIEN THEN 1 ELSE 0 END) AS XUAT_AM_DAU_TIEN,
        CASE WHEN LOI_DULIEU IS NOT NULL THEN LOI_DULIEU
            WHEN SO_DONG_LOI>0 THEN N'Chưa đối chiếu được tồn: cần sửa dòng thiếu ngày/số lượng/quy đổi trước'
            WHEN THUTU=AM_DAUTIEN THEN N'Phiếu xuất đầu tiên vượt tồn: kiểm tra phiếu nhập trước đó và đầu kỳ'
            WHEN KIND=2 AND TON_SAU<0 THEN N'Xuất khi tồn không đủ'
            ELSE N'Đủ tồn theo ngày THOIGIANTHEM' END AS KETQUA,
        CASE WHEN NGAYLAP IS NULL THEN N'Thiếu NGAYLAP'
            WHEN CONVERT(date,NGAYLAP)<>NGAY_TINH THEN N'Ngày lập khác ngày thêm; cần đối chiếu, chưa kết luận sai'
            ELSE N'' END AS DOI_CHIEU_NGAY,
        ID_PHIEU,ID_CHITIET
    FROM Marked
    WHERE @ChiHienLoi=0 OR LOI_DULIEU IS NOT NULL
        OR (SO_DONG_LOI=0 AND KIND=2 AND TON_SAU<0)
        OR NGAYLAP IS NULL OR CONVERT(date,NGAYLAP)<>NGAY_TINH
    ORDER BY THUTU;
END;
GO
/*
EXEC dbo.KiemTraThuTuNhapXuat
    @LOC_ID=N'02',
    @ID_HANGHOAKHO=N'383f0d23-c25f-4a34-af71-e20436e60212',
    @ChiHienLoi=1;
-- Doi thanh @ChiHienLoi=0 de xem ca so nhap xuat theo ngay, ke ca dong dung.
-- Khong co dau ky: mo phong ton dau = 0, khong tao dau ky.
-- Co dau ky: chi xet tu TUNGAY. Cung ngay nhap -> khach tra -> xuat, bo qua gio.
-- Chi chan doan thoi gian/so luong; khong phai kiem tra day du gia von khach tra.
*/
