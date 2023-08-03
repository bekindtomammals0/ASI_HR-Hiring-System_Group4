CREATE TABLE [dbo].[CharacterReference]
(
    [ID] INT NOT NULL,
    [email] VARCHAR(255) NOT NULL,
    [firstName] VARCHAR(255) NOT NULL,
    [lastName] VARCHAR(255) NOT NULL,
    [responded] BIT NOT NULL DEFAULT 0,
    PRIMARY KEY CLUSTERED ([ID] ASC)
)
