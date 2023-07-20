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

CREATE TABLE [dbo].[JobOpening] (
    [ID]                INT           NOT NULL,
    [employmentTypeID]  INT           NOT NULL,
    [experienceLevelID] INT           NOT NULL,
    [title]             CHAR (50)     NOT NULL,
    [description]       VARCHAR (4000) NULL,
    [createdTime]       DATETIME      NOT NULL,
    [createdBy]         CHAR (50)     NOT NULL,
    [updatedTime]       DATETIME      NULL,
    [updatedBy]         CHAR (50)     NULL
);


