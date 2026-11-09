-- Trong SSMS chọn database nghiệp vụ. Để NULL để chạy cho tất cả hàng đã khai báo đầu kỳ.
DECLARE @ChiNhanh nvarchar(50) = NULL;
DECLARE @HangHoaKho nvarchar(50) = NULL; -- ID_HANGHOAKHO, không phải mã hàng.

SET NOCOUNT ON;
SET XACT_ABORT ON;
IF OBJECT_ID('dbo.TinhGiaVonHangKho','P') IS NULL
    THROW 51001, N'Hãy chạy file 20261105_OpeningStockCost.sql đã sửa trước.', 1;

DECLARE @loc nvarchar(50), @stock nvarchar(50), @locked nvarchar(50), @done int=0;
DECLARE @errors TABLE (LOC_ID nvarchar(50), ID_HANGHOAKHO nvarchar(50), LYDO nvarchar(4000));
DECLARE items CURSOR LOCAL STATIC READ_ONLY FOR
    SELECT LOC_ID, ID_HANGHOAKHO FROM dbo.ct_GiaVonDauKy
    WHERE (@ChiNhanh IS NULL OR LOC_ID=@ChiNhanh)
        AND (@HangHoaKho IS NULL OR ID_HANGHOAKHO=@HangHoaKho)
    ORDER BY LOC_ID, ID_HANGHOAKHO;
OPEN items;
FETCH NEXT FROM items INTO @loc,@stock;
WHILE @@FETCH_STATUS=0
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
        SET @locked=NULL;
        SELECT @locked=ID FROM dbo.dm_HangHoa_Kho WITH (UPDLOCK,HOLDLOCK) WHERE LOC_ID=@loc AND ID=@stock;
        IF @locked IS NULL THROW 51104, N'Không tìm thấy hàng tại kho đã khai báo đầu kỳ.', 1;
        EXEC dbo.TinhGiaVonHangKho @loc=@loc, @stock=@stock;
        COMMIT;
        SET @done+=1;
    END TRY
    BEGIN CATCH
        IF XACT_STATE()<>0 ROLLBACK;
        IF ERROR_NUMBER() NOT BETWEEN 51101 AND 51104 THROW;
        INSERT @errors VALUES (@loc,@stock,ERROR_MESSAGE());
    END CATCH;
    FETCH NEXT FROM items INTO @loc,@stock;
END;
CLOSE items;
DEALLOCATE items;
SELECT @done AS SO_HANG_KHO_DA_TINH, COUNT(*) AS SO_HANG_KHO_LOI FROM @errors;
SELECT LOC_ID, ID_HANGHOAKHO, LYDO FROM @errors ORDER BY LOC_ID,ID_HANGHOAKHO;
