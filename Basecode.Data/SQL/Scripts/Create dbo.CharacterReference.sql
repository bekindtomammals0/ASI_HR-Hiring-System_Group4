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

CREATE TABLE [dbo].[CharacterReference] (
    [ID]        INT           NOT NULL,
    [email]     VARCHAR (255) NOT NULL,
    [firstName] VARCHAR (255) NOT NULL,
    [lastName]  VARCHAR (255) NOT NULL,
    [responded] BIT           NOT NULL
);


