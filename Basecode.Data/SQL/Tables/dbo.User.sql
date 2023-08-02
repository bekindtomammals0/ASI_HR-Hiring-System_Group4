CREATE TABLE [dbo].[User] (
    [ID]          INT           NOT NULL,
    [email]       VARCHAR (255) NOT NULL,
    [password]    VARCHAR (255) NOT NULL,
    [firstName]   VARCHAR (255) NOT NULL,
    [lastName]    VARCHAR (255) NOT NULL,
    [dateCreated] DATETIME      NULL,
    [lastActive]  DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

