SET XACT_ABORT ON;
BEGIN TRANSACTION;
GO
IF OBJECT_ID(N'dbo.ct_LenhDongGoi',N'U') IS NULL
BEGIN
    CREATE TABLE dbo.ct_LenhDongGoi
    (
        LOC_ID nvarchar(50) NOT NULL,
        ID uniqueidentifier NOT NULL,
        Depot nvarchar(50) NOT NULL,
        SourceStock nvarchar(50) NOT NULL,
        SourceDetail nvarchar(50) NOT NULL,
        SourceKg decimal(18,6) NOT NULL,
        Labor decimal(18,2) NOT NULL,
        PlanJson nvarchar(max) NOT NULL,
        OutputId nvarchar(50) NOT NULL,
        OutputCode nvarchar(50) NOT NULL,
        CreatedAt datetime2(0) NOT NULL,
        InputId nvarchar(50) NULL,
        InputCode nvarchar(50) NULL,
        ReceivedAt datetime2(0) NULL,
        MaterialCost decimal(18,2) NULL,
        LossKg decimal(18,6) NULL,
        LossCost decimal(18,2) NULL,
        ReceiptJson nvarchar(max) NULL,
        CONSTRAINT PK_ct_LenhDongGoi PRIMARY KEY(LOC_ID,ID),
        CONSTRAINT UQ_ct_LenhDongGoi_Output UNIQUE(LOC_ID,OutputId),
        CONSTRAINT CK_ct_LenhDongGoi_Amounts CHECK(SourceKg>0 AND Labor>=0 AND LossKg>=0 AND LossCost>=0)
    );
    CREATE UNIQUE INDEX IX_ct_LenhDongGoi_Input ON dbo.ct_LenhDongGoi(LOC_ID,InputId) WHERE InputId IS NOT NULL;
    CREATE INDEX IX_ct_LenhDongGoi_Depot ON dbo.ct_LenhDongGoi(LOC_ID,Depot,CreatedAt DESC);
END;
GO
INSERT dbo.dm_LoaiPhieuXuat(LOC_ID,ID,MA,NAME,ISACTIVE,ISDEFAULT,ISSYSTEM,TYPE,ISTRAHANG,THOIGIANTHEM)
SELECT k.LOC_ID,N'THP-DONG-GOI',N'DGX',N'Xuất sản xuất',1,0,1,0,0,DATEADD(hour,7,SYSUTCDATETIME())
FROM (SELECT DISTINCT LOC_ID FROM dbo.dm_Kho) k
WHERE NOT EXISTS(SELECT 1 FROM dbo.dm_LoaiPhieuXuat t WHERE t.LOC_ID=k.LOC_ID AND t.ID=N'THP-DONG-GOI');
INSERT dbo.dm_LoaiPhieuNhap(LOC_ID,ID,MA,NAME,ISACTIVE,ISDEFAULT,ISSYSTEM,TYPE,ISNHAPTRAHANG,THOIGIANTHEM)
SELECT k.LOC_ID,N'THP-DONG-GOI',N'DGN',N'Nhập thành phẩm',1,0,1,0,0,DATEADD(hour,7,SYSUTCDATETIME())
FROM (SELECT DISTINCT LOC_ID FROM dbo.dm_Kho) k
WHERE NOT EXISTS(SELECT 1 FROM dbo.dm_LoaiPhieuNhap t WHERE t.LOC_ID=k.LOC_ID AND t.ID=N'THP-DONG-GOI');
GO
-- These guards apply only to vouchers generated and linked by a packing order.
CREATE OR ALTER TRIGGER dbo.TR_PhieuXuat_LenhDongGoi ON dbo.ct_PhieuXuat AFTER UPDATE, DELETE AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM deleted d JOIN dbo.ct_LenhDongGoi p ON p.LOC_ID=d.LOC_ID AND p.OutputId=d.ID)
        THROW 51220, N'Phiếu xuất thuộc lệnh đóng gói, không sửa hoặc xóa từ màn hình phiếu xuất.', 1;
END;
GO
CREATE OR ALTER TRIGGER dbo.TR_PhieuNhap_LenhDongGoi ON dbo.ct_PhieuNhap AFTER UPDATE, DELETE AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM deleted d JOIN dbo.ct_LenhDongGoi p ON p.LOC_ID=d.LOC_ID AND p.InputId=d.ID)
        THROW 51220, N'Phiếu nhập thuộc lệnh đóng gói, không sửa hoặc xóa từ màn hình phiếu nhập.', 1;
END;
GO
CREATE OR ALTER TRIGGER dbo.TR_PhieuXuatChiTiet_LenhDongGoi ON dbo.ct_PhieuXuat_ChiTiet AFTER INSERT, UPDATE, DELETE AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM deleted d JOIN dbo.ct_LenhDongGoi p ON p.LOC_ID=d.LOC_ID AND p.OutputId=d.ID_PHIEUXUAT
               WHERE NOT EXISTS(SELECT 1 FROM inserted i WHERE i.LOC_ID=d.LOC_ID AND i.ID=d.ID AND i.ID_PHIEUXUAT=d.ID_PHIEUXUAT))
       OR EXISTS (SELECT 1 FROM inserted i JOIN dbo.ct_LenhDongGoi p ON p.LOC_ID=i.LOC_ID AND p.OutputId=i.ID_PHIEUXUAT
                  WHERE NOT EXISTS(SELECT 1 FROM deleted d WHERE d.LOC_ID=i.LOC_ID AND d.ID=i.ID AND d.ID_PHIEUXUAT=i.ID_PHIEUXUAT))
       OR ((UPDATE(SOLUONG) OR UPDATE(TYLE_QD) OR UPDATE(ID_HANGHOAKHO) OR UPDATE(ID_DVT) OR UPDATE(TONGSOLUONG)
             OR UPDATE(DONGIA) OR UPDATE(THANHTIEN) OR UPDATE(TONGCONG))
           AND EXISTS(SELECT 1 FROM deleted d JOIN dbo.ct_LenhDongGoi p ON p.LOC_ID=d.LOC_ID AND p.OutputId=d.ID_PHIEUXUAT))
        THROW 51220, N'Chi tiết xuất thuộc lệnh đóng gói.', 1;
END;
GO
CREATE OR ALTER TRIGGER dbo.TR_PhieuNhapChiTiet_LenhDongGoi ON dbo.ct_PhieuNhap_ChiTiet AFTER INSERT, UPDATE, DELETE AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM deleted d JOIN dbo.ct_LenhDongGoi p ON p.LOC_ID=d.LOC_ID AND p.InputId=d.ID_PHIEUNHAP)
       OR EXISTS (SELECT 1 FROM inserted i JOIN dbo.ct_LenhDongGoi p ON p.LOC_ID=i.LOC_ID AND p.InputId=i.ID_PHIEUNHAP)
        THROW 51220, N'Chi tiết nhập thuộc lệnh đóng gói.', 1;
END;
GO
COMMIT TRANSACTION;
GO
