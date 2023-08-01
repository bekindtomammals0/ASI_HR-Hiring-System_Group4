USE [BaseCodeDB]
GO

/* Avengers! Please take note that 
the name of the DB being used in line 1 is correct.
Thank you! 
-Barcenilla, AJ*/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ProcessStatus] (
    [ID] INT NOT NULL PRIMARY KEY,
    [status] CHAR (50) NOT NULL
);


