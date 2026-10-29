-- Run once against the application database before deploying the API and MVC site.
-- Existing customer and document tables are unchanged. All timestamps below are UTC.
SET XACT_ABORT ON;
BEGIN TRANSACTION;
IF OBJECT_ID(N'dbo.web_CustomerPortalLink', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.web_CustomerPortalLink (
        Id nvarchar(50) NOT NULL CONSTRAINT PK_web_CustomerPortalLink PRIMARY KEY,
        LocId nvarchar(50) NOT NULL,
        CustomerId nvarchar(50) NOT NULL,
        TokenHash nvarchar(64) NOT NULL,
        IsActive bit NOT NULL,
        CreatedUtc datetime2 NOT NULL,
        ExpiresUtc datetime2 NULL,
        RevokedUtc datetime2 NULL,
        CreatedBy nvarchar(256) NOT NULL,
        Version rowversion NOT NULL,
        CONSTRAINT UQ_CustomerPortal_Customer UNIQUE (LocId, CustomerId),
        CONSTRAINT UQ_CustomerPortal_TokenHash UNIQUE (TokenHash)
    );
END;
COMMIT TRANSACTION;
