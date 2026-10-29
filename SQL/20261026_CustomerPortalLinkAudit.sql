-- Run after 20261026_CustomerPortalLink.sql, before deploying the updated API.
-- Append-only audit data. No token or token hash is stored in this table.
SET XACT_ABORT ON;
BEGIN TRANSACTION;
IF OBJECT_ID(N'dbo.web_CustomerPortalLinkAudit', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.web_CustomerPortalLinkAudit (
        Id nvarchar(50) NOT NULL CONSTRAINT PK_web_CustomerPortalLinkAudit PRIMARY KEY,
        LocId nvarchar(50) NOT NULL,
        CustomerId nvarchar(50) NOT NULL,
        CustomerCode nvarchar(50) NOT NULL,
        CustomerName nvarchar(200) NOT NULL,
        Action nvarchar(20) NOT NULL,
        OccurredUtc datetime2 NOT NULL,
        ActorUserId nvarchar(50) NOT NULL,
        ActorUsername nvarchar(256) NOT NULL,
        ActorDisplayName nvarchar(256) NOT NULL,
        ExpiresUtc datetime2 NULL,
        PreviousExpiresUtc datetime2 NULL,
        CONSTRAINT CK_CustomerPortalLinkAudit_Action CHECK (Action IN ('created', 'reissued', 'revoked'))
    );
    CREATE INDEX IX_CustomerPortalLinkAudit_CustomerDate
        ON dbo.web_CustomerPortalLinkAudit (LocId, CustomerId, OccurredUtc DESC);
END;
COMMIT TRANSACTION;
