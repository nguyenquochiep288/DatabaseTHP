SET XACT_ABORT ON;
BEGIN TRANSACTION;
GO
IF COL_LENGTH(N'dbo.ct_LenhDongGoi',N'ClosedWithoutReceipt') IS NULL
    ALTER TABLE dbo.ct_LenhDongGoi ADD ClosedWithoutReceipt bit NOT NULL
        CONSTRAINT DF_ct_LenhDongGoi_ClosedWithoutReceipt DEFAULT (0);

IF OBJECT_ID(N'dbo.ct_LenhDongGoi_Dot',N'U') IS NULL
BEGIN
    CREATE TABLE dbo.ct_LenhDongGoi_Dot
    (
        LOC_ID nvarchar(50) NOT NULL,
        OrderId uniqueidentifier NOT NULL,
        RequestId uniqueidentifier NOT NULL,
        Direction tinyint NOT NULL,
        VoucherId nvarchar(50) NOT NULL,
        VoucherCode nvarchar(50) NOT NULL,
        PostedAt datetime2(0) NOT NULL,
        Kg decimal(18,6) NOT NULL,
        CommonCost decimal(18,2) NULL,
        PackageCost decimal(18,2) NULL,
        ReceiptValue decimal(18,2) NULL,
        ReceiptJson nvarchar(max) NULL,
        CONSTRAINT PK_ct_LenhDongGoi_Dot PRIMARY KEY (LOC_ID,OrderId,RequestId),
        CONSTRAINT UQ_ct_LenhDongGoi_Dot_Phieu UNIQUE (LOC_ID,Direction,VoucherId),
        CONSTRAINT FK_ct_LenhDongGoi_Dot_Order FOREIGN KEY (LOC_ID,OrderId) REFERENCES dbo.ct_LenhDongGoi(LOC_ID,ID),
        CONSTRAINT CK_ct_LenhDongGoi_Dot CHECK (Direction IN (0,1) AND Kg>0)
    );
END;
GO
CREATE OR ALTER VIEW dbo.v_LenhDongGoi_Phieu
AS
SELECT LOC_ID,ID AS OrderId,0 AS Direction,OutputId AS VoucherId,OutputCode AS VoucherCode,CreatedAt AS PostedAt FROM dbo.ct_LenhDongGoi
UNION ALL
SELECT LOC_ID,ID,1,InputId,InputCode,ReceivedAt FROM dbo.ct_LenhDongGoi WHERE InputId IS NOT NULL
UNION ALL
SELECT LOC_ID,OrderId,Direction,VoucherId,VoucherCode,PostedAt FROM dbo.ct_LenhDongGoi_Dot;
GO
CREATE OR ALTER TRIGGER dbo.TR_PhieuXuat_LenhDongGoi ON dbo.ct_PhieuXuat AFTER UPDATE, DELETE AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM deleted d JOIN dbo.v_LenhDongGoi_Phieu p ON p.LOC_ID=d.LOC_ID AND p.Direction=0 AND p.VoucherId=d.ID)
        THROW 51220, N'Phiếu xuất thuộc lệnh đóng gói, không sửa hoặc xóa từ màn hình phiếu xuất.', 1;
END;
GO
CREATE OR ALTER TRIGGER dbo.TR_PhieuNhap_LenhDongGoi ON dbo.ct_PhieuNhap AFTER UPDATE, DELETE AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM deleted d JOIN dbo.v_LenhDongGoi_Phieu p ON p.LOC_ID=d.LOC_ID AND p.Direction=1 AND p.VoucherId=d.ID)
        THROW 51220, N'Phiếu nhập thuộc lệnh đóng gói, không sửa hoặc xóa từ màn hình phiếu nhập.', 1;
END;
GO
CREATE OR ALTER TRIGGER dbo.TR_PhieuXuatChiTiet_LenhDongGoi ON dbo.ct_PhieuXuat_ChiTiet AFTER INSERT, UPDATE, DELETE AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM deleted d JOIN dbo.v_LenhDongGoi_Phieu p ON p.LOC_ID=d.LOC_ID AND p.Direction=0 AND p.VoucherId=d.ID_PHIEUXUAT
               WHERE NOT EXISTS(SELECT 1 FROM inserted i WHERE i.LOC_ID=d.LOC_ID AND i.ID=d.ID AND i.ID_PHIEUXUAT=d.ID_PHIEUXUAT))
       OR EXISTS (SELECT 1 FROM inserted i JOIN dbo.v_LenhDongGoi_Phieu p ON p.LOC_ID=i.LOC_ID AND p.Direction=0 AND p.VoucherId=i.ID_PHIEUXUAT
                  WHERE NOT EXISTS(SELECT 1 FROM deleted d WHERE d.LOC_ID=i.LOC_ID AND d.ID=i.ID AND d.ID_PHIEUXUAT=i.ID_PHIEUXUAT))
       OR ((UPDATE(SOLUONG) OR UPDATE(TYLE_QD) OR UPDATE(ID_HANGHOAKHO) OR UPDATE(ID_DVT) OR UPDATE(TONGSOLUONG)
             OR UPDATE(DONGIA) OR UPDATE(THANHTIEN) OR UPDATE(TONGCONG))
           AND EXISTS(SELECT 1 FROM deleted d JOIN dbo.v_LenhDongGoi_Phieu p ON p.LOC_ID=d.LOC_ID AND p.Direction=0 AND p.VoucherId=d.ID_PHIEUXUAT))
        THROW 51220, N'Chi tiết xuất thuộc lệnh đóng gói.', 1;
END;
GO
CREATE OR ALTER TRIGGER dbo.TR_PhieuNhapChiTiet_LenhDongGoi ON dbo.ct_PhieuNhap_ChiTiet AFTER INSERT, UPDATE, DELETE AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM deleted d JOIN dbo.v_LenhDongGoi_Phieu p ON p.LOC_ID=d.LOC_ID AND p.Direction=1 AND p.VoucherId=d.ID_PHIEUNHAP)
       OR EXISTS (SELECT 1 FROM inserted i JOIN dbo.v_LenhDongGoi_Phieu p ON p.LOC_ID=i.LOC_ID AND p.Direction=1 AND p.VoucherId=i.ID_PHIEUNHAP)
        THROW 51220, N'Chi tiết nhập thuộc lệnh đóng gói.', 1;
END;
GO
COMMIT TRANSACTION;
GO
