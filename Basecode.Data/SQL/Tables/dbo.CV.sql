CREATE TABLE [dbo].[CV] (
    [ID]        INT             NOT NULL,
    [file]      VARBINARY (MAX) NOT NULL,
    [fileName]  NVARCHAR(255)   NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);
