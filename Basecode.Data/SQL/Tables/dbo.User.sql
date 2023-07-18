CREATE TABLE [dbo].[User]
(
    [ID] INT NOT NULL PRIMARY KEY,
    [email] VARCHAR(255) NOT NULL,
    [password] VARCHAR(255) NOT NULL,
    [firstName] VARCHAR(255) NOT NULL,
    [lastName] VARCHAR(255) NOT NULL,
    [dateCreated] DATETIME,
    [lastActive] DATETIME,
    [isApplying] BIT NOT NULL DEFAULT 0
)