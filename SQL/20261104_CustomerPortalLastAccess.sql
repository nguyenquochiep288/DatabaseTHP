-- Apply after the customer portal link table has been created.
IF COL_LENGTH(N'dbo.web_CustomerPortalLink', N'LastAccessUtc') IS NULL
    ALTER TABLE dbo.web_CustomerPortalLink ADD LastAccessUtc datetime2 NULL;
