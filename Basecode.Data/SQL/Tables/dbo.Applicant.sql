CREATE TABLE [dbo].[Applicant]
(
    [ID] INT NOT NULL PRIMARY KEY,
    [userID] INT NOT NULL,
    [civilStatusID] INT NOT NULL,
    [cvID] INT,
    [jobOpeningID] INT,
    [characterReferenceID] INT,
    [processStatusID] INT,
    [characterReferenceResponded] BIT NOT NULL DEFAULT 0,
    [contactNo] CHAR(11) NOT NULL,
    CONSTRAINT FK_Applicant_User FOREIGN KEY ([userID])
        REFERENCES [dbo].[User] ([ID]),
    CONSTRAINT FK_Applicant_CivilStatus FOREIGN KEY ([civilStatusID])
        REFERENCES [dbo].[CivilStatus] ([ID]),
    CONSTRAINT FK_Applicant_CV FOREIGN KEY ([cvID])
        REFERENCES [dbo].[CV] ([ID]),
    CONSTRAINT FK_Applicant_JobOpening FOREIGN KEY ([jobOpeningID])
        REFERENCES [dbo].[JobOpening] ([ID]),
    CONSTRAINT FK_Applicant_CharacterReference FOREIGN KEY ([characterReferenceID])
        REFERENCES [dbo].[CharacterReference] ([ID]),
    CONSTRAINT FK_Applicant_ProcessStatus FOREIGN KEY ([processStatusID])
        REFERENCES [dbo].[ProcessStatus] ([ID])
)
