CREATE TABLE [dbo].[JobOpening]
(
    [ID] INT NOT NULL PRIMARY KEY,
    [employmentTypeID] INT NOT NULL,
    [experienceLevelID] INT NOT NULL,
    [title] CHAR(50) NOT NULL,
    [description] VARCHAR(255),
    [createdTime] DATETIME NOT NULL,
    [createdBy] CHAR(50) NOT NULL,
    [updatedTime] DATETIME,
    [updatedBy] CHAR(50),
    CONSTRAINT FK_JobOpening_EmploymentType FOREIGN KEY ([employmentTypeID])
        REFERENCES [dbo].[EmploymentType] ([ID]),
    CONSTRAINT FK_JobOpening_ExperienceLevel FOREIGN KEY ([experienceLevelID])
        REFERENCES [dbo].[ExperienceLevel] ([ID])
)
