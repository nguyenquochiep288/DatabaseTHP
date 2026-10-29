-- Additive upgrade: keeps all current links valid. Old hashes cannot reconstruct tokens.
-- New/reissued links retain an encrypted token for authorized staff to copy later.
SET XACT_ABORT ON;
BEGIN TRANSACTION;
IF COL_LENGTH(N'dbo.web_CustomerPortalLink', N'ProtectedToken') IS NULL
    ALTER TABLE dbo.web_CustomerPortalLink ADD ProtectedToken nvarchar(512) NULL;
COMMIT TRANSACTION;
