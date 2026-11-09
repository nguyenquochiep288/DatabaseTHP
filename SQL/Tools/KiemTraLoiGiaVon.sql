-- CHI DOC DU LIEU: khong sua phieu, dau ky hay GIAVON.
-- Chon database nghiep vu trong SSMS, sua bo loc duoi day roi chay ca file.
DECLARE @LOC_ID nvarchar(50) = N'02';
DECLARE @ID_KHO nvarchar(50) = NULL;
DECLARE @ID_HANGHOAKHO nvarchar(50) = NULL;
SET NOCOUNT ON;
IF NULLIF(LTRIM(RTRIM(@LOC_ID)),N'') IS NULL
    THROW 51211,N'Phải chọn LOC_ID.',1;

DROP TABLE IF EXISTS #GVScope;
DROP TABLE IF EXISTS #GVMoves;
DROP TABLE IF EXISTS #GVBalance;

SELECT s.LOC_ID,s.ID AS ID_HANGHOAKHO,s.ID_KHO,p.MA AS MAHANG,p.NAME AS TENHANG,
    k.NAME AS TENKHO,p.ID_DVT,p.ID_DVT_QD,p.TYLE_QD AS TYLE_QD_DANHMUC,
    o.TUNGAY,COALESCE(o.SOLUONG,0) AS TON_DAUKY,
    CONVERT(bit,CASE WHEN o.ID_HANGHOAKHO IS NULL THEN 0 ELSE 1 END) AS CO_DAUKY
INTO #GVScope
FROM dbo.dm_HangHoa_Kho s
LEFT JOIN dbo.dm_HangHoa p ON p.LOC_ID=s.LOC_ID AND p.ID=s.ID_HANGHOA
LEFT JOIN dbo.dm_Kho k ON k.LOC_ID=s.LOC_ID AND k.ID=s.ID_KHO
LEFT JOIN dbo.ct_GiaVonDauKy o ON o.LOC_ID=s.LOC_ID AND o.ID_HANGHOAKHO=s.ID
WHERE s.LOC_ID=@LOC_ID AND (@ID_KHO IS NULL OR s.ID_KHO=@ID_KHO)
    AND (@ID_HANGHOAKHO IS NULL OR s.ID=@ID_HANGHOAKHO);
CREATE UNIQUE CLUSTERED INDEX IX_GVScope ON #GVScope(ID_HANGHOAKHO);

-- Thu tu giong TinhGiaVonHangKho: ngay gio, nhap/khach tra/xuat, so phieu, ID chi tiet.
SELECT m.*,TRY_CONVERT(decimal(28,6),m.SOLUONG*m.TYLE_QD) AS SOLUONG_NHO,
    CONVERT(nvarchar(300),CASE
        WHEN m.HEADER_ID IS NULL THEN N'Không tìm thấy phiếu cha'
        WHEN m.NGAYLAP IS NULL THEN N'Phiếu thiếu ngày lập'
        WHEN m.SOLUONG IS NULL THEN N'Số lượng NULL'
        WHEN m.SOLUONG<0 THEN N'Số lượng âm'
        WHEN m.TYLE_QD IS NULL OR m.TYLE_QD<=0 THEN N'Tỷ lệ quy đổi NULL hoặc <= 0'
        WHEN TRY_CONVERT(decimal(18,6),m.TYLE_QD) IS NULL
            OR TRY_CONVERT(decimal(18,6),m.TYLE_QD)<=0 THEN N'Tỷ lệ quy đổi ngoài giới hạn tính vốn'
        WHEN TRY_CONVERT(decimal(28,6),m.SOLUONG*m.TYLE_QD) IS NULL
            OR TRY_CONVERT(decimal(28,6),m.SOLUONG*m.TYLE_QD)<=0 THEN N'Số lượng quy đổi ngoài giới hạn hoặc làm tròn về 0'
        WHEN m.KIND<2 AND m.THANHTIEN IS NULL THEN N'Thành tiền nhập NULL'
        WHEN m.KIND=0 AND m.THANHTIEN<0 THEN N'Thành tiền nhập âm'
    END) AS LYDO
INTO #GVMoves
FROM (
    SELECT d.ID_HANGHOAKHO,d.ID AS ID_CHITIET,d.ID_PHIEUNHAP AS ID_PHIEU,
        h.ID AS HEADER_ID,h.MAPHIEU,h.SOPHIEU,h.NGAYLAP,
        CASE WHEN t.ISNHAPTRAHANG=1 THEN 1 ELSE 0 END AS KIND,
        d.SOLUONG,d.TYLE_QD,d.ID_DVT AS ID_DVT_PHIEU,d.THANHTIEN
    FROM dbo.ct_PhieuNhap_ChiTiet d
    JOIN #GVScope s ON s.LOC_ID=d.LOC_ID AND s.ID_HANGHOAKHO=d.ID_HANGHOAKHO
    LEFT JOIN dbo.ct_PhieuNhap h ON h.LOC_ID=d.LOC_ID AND h.ID=d.ID_PHIEUNHAP
    LEFT JOIN dbo.dm_LoaiPhieuNhap t ON t.LOC_ID=h.LOC_ID AND t.ID=h.ID_LOAIPHIEUNHAP
    WHERE (d.SOLUONG IS NULL OR d.SOLUONG<>0)
        AND (s.TUNGAY IS NULL OR h.NGAYLAP IS NULL OR h.NGAYLAP>=s.TUNGAY)
    UNION ALL
    SELECT d.ID_HANGHOAKHO,d.ID,d.ID_PHIEUXUAT,h.ID,h.MAPHIEU,h.SOPHIEU,h.NGAYLAP,2,
        d.SOLUONG,d.TYLE_QD,d.ID_DVT,d.THANHTIEN
    FROM dbo.ct_PhieuXuat_ChiTiet d
    JOIN #GVScope s ON s.LOC_ID=d.LOC_ID AND s.ID_HANGHOAKHO=d.ID_HANGHOAKHO
    LEFT JOIN dbo.ct_PhieuXuat h ON h.LOC_ID=d.LOC_ID AND h.ID=d.ID_PHIEUXUAT
    WHERE (d.SOLUONG IS NULL OR d.SOLUONG<>0)
        AND (s.TUNGAY IS NULL OR h.NGAYLAP IS NULL OR h.NGAYLAP>=s.TUNGAY)
) m;
CREATE INDEX IX_GVMoves ON #GVMoves(ID_HANGHOAKHO);

-- Bang 1: sua dung dong phieu; khong tu gan TYLE_QD=1 hay lay ty le danh muc hien tai.
SELECT s.MAHANG,s.TENHANG,s.TENKHO,
    CASE m.KIND WHEN 0 THEN N'Nhập' WHEN 1 THEN N'Nhập khách trả' ELSE N'Xuất' END AS LOAI_PHIEU,
    m.MAPHIEU,m.SOPHIEU,m.NGAYLAP,m.SOLUONG,m.TYLE_QD,m.SOLUONG_NHO,m.LYDO,
    m.ID_DVT_PHIEU,s.ID_DVT,s.ID_DVT_QD,s.TYLE_QD_DANHMUC,
    s.LOC_ID,s.ID_KHO,s.ID_HANGHOAKHO,m.ID_PHIEU,m.ID_CHITIET
FROM #GVMoves m JOIN #GVScope s ON s.ID_HANGHOAKHO=m.ID_HANGHOAKHO
WHERE m.LYDO IS NOT NULL
ORDER BY s.MAHANG,s.ID_KHO,m.NGAYLAP,m.KIND,m.SOPHIEU,m.ID_CHITIET;

-- Khong chan doan am kho cho hang co dong loi: can sua dong loi roi chay lai.
SELECT m.ID_HANGHOAKHO,m.ID_CHITIET,m.ID_PHIEU,m.MAPHIEU,m.SOPHIEU,m.NGAYLAP,m.KIND,m.SOLUONG_NHO,
    s.TON_DAUKY+SUM(CASE WHEN m.KIND=2 THEN -m.SOLUONG_NHO ELSE m.SOLUONG_NHO END)
        OVER (PARTITION BY m.ID_HANGHOAKHO ORDER BY m.NGAYLAP,m.KIND,m.SOPHIEU,m.ID_CHITIET
            ROWS UNBOUNDED PRECEDING) AS TON_SAU
INTO #GVBalance
FROM #GVMoves m JOIN #GVScope s ON s.ID_HANGHOAKHO=m.ID_HANGHOAKHO
WHERE NOT EXISTS(SELECT 1 FROM #GVMoves bad WHERE bad.ID_HANGHOAKHO=m.ID_HANGHOAKHO AND bad.LYDO IS NOT NULL);

-- Bang 2: phieu xuat dau tien lam am ton (don vi nho nhat), khong phai ton hien tai.
;WITH Thieu AS (
    SELECT *,ROW_NUMBER() OVER(PARTITION BY ID_HANGHOAKHO ORDER BY NGAYLAP,KIND,SOPHIEU,ID_CHITIET) AS RN
    FROM #GVBalance WHERE KIND=2 AND TON_SAU<0
)
SELECT s.MAHANG,s.TENHANG,s.TENKHO,b.MAPHIEU,b.SOPHIEU,b.NGAYLAP,
    s.CO_DAUKY,s.TUNGAY,s.TON_DAUKY,
    b.TON_SAU+b.SOLUONG_NHO AS TON_TRUOC_XUAT,b.SOLUONG_NHO AS SL_XUAT_NHO,
    -b.TON_SAU AS SL_THIEU_TAI_PHIEU,
    N'Kiểm tra tồn đầu kỳ, phiếu nhập thiếu/sai kho, ngày giờ nhập xuất và quy đổi.' AS HUONG_KIEM_TRA,
    s.LOC_ID,s.ID_KHO,s.ID_HANGHOAKHO,b.ID_PHIEU,b.ID_CHITIET
FROM Thieu b JOIN #GVScope s ON s.ID_HANGHOAKHO=b.ID_HANGHOAKHO
WHERE b.RN=1 ORDER BY s.MAHANG,s.ID_KHO;

-- Bang 3: khong co dong phat sinh trong pham vi tinh; khong phai loi du lieu.
SELECT s.MAHANG,s.TENHANG,s.TENKHO,s.CO_DAUKY,s.TUNGAY,
    N'Không có phát sinh trong phạm vi tính giá vốn' AS TRANGTHAI,
    s.LOC_ID,s.ID_KHO,s.ID_HANGHOAKHO
FROM #GVScope s WHERE NOT EXISTS(SELECT 1 FROM #GVMoves m WHERE m.ID_HANGHOAKHO=s.ID_HANGHOAKHO)
ORDER BY s.MAHANG,s.ID_KHO;

-- Day la chan doan so luong/quy doi. Van can kiem tra rieng gia von hang khach tra.
-- Hang khong co dau ky: bang 2 mo phong ton ban dau = 0, KHONG ghi dau ky vao database.
DROP TABLE #GVBalance;
DROP TABLE #GVMoves;
DROP TABLE #GVScope;
