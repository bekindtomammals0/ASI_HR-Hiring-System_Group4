CREATE TABLE [dbo].[CharacterReference]
(
    [ID] INT NOT NULL PRIMARY KEY,
    [email] VARCHAR(255) NOT NULL,
    [firstName] VARCHAR(255) NOT NULL,
    [lastName] VARCHAR(255) NOT NULL,
    [responded] BIT NOT NULL DEFAULT 0
)
