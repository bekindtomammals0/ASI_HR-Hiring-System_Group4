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
    [firstName]                   VARCHAR(255) NOT NULL,
    [lastName]                    VARCHAR(255) NOT NULL,
    [email]                       VARCHAR(255) NOT NULL,
    [civilStatusID]               INT       NOT NULL,
    [cvID]                        INT       NULL,
    [jobOpeningID]                INT       NULL,
    [characterReferenceID]        INT       NULL,
    [processStatusID]             INT       NULL,
    [characterReferenceResponded] BIT       NOT NULL,
    [contactNo]                   CHAR (11) NOT NULL,
    [dateApplied]                 DATE      NOT NULL,
    [scheduleDate]                DATE      NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Applicant_CivilStatus] FOREIGN KEY ([civilStatusID]) REFERENCES [dbo].[CivilStatus] ([ID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Applicant_CV] FOREIGN KEY ([cvID]) REFERENCES [dbo].[CV] ([ID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Applicant_JobOpening] FOREIGN KEY ([jobOpeningID]) REFERENCES [dbo].[JobOpening] ([ID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Applicant_CharacterReference] FOREIGN KEY ([characterReferenceID]) REFERENCES [dbo].[CharacterReference] ([ID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Applicant_ProcessStatus] FOREIGN KEY ([processStatusID]) REFERENCES [dbo].[ProcessStatus] ([ID]) ON DELETE CASCADE
);
