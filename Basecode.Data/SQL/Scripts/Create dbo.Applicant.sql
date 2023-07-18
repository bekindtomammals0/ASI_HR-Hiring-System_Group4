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

CREATE TABLE [dbo].[Applicant] (
    [ID]                          INT       NOT NULL,
    [userID]                      INT       NOT NULL,
    [civilStatusID]               INT       NOT NULL,
    [cvID]                        INT       NULL,
    [jobOpeningID]                INT       NULL,
    [characterReferenceID]        INT       NULL,
    [processStatusID]             INT       NULL,
    [characterReferenceResponded] BIT       NOT NULL,
    [contactNo]                   CHAR (11) NOT NULL
);


