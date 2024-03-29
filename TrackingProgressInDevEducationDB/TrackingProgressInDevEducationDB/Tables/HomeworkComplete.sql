﻿CREATE TABLE [TrackingProgressInDevEducationDB].[HomeworkComplete] (
    [id]         INT IDENTITY (1, 1) NOT NULL,
    [HomeworkId] INT NOT NULL,
    [StudentId]  INT NOT NULL,
    [Status]     BIT NOT NULL DEFAULT 0,
    [ApproveDate] DATE NULL, 
    [Score] INT NULL, 
    [CreatedOn] DATE NULL DEFAULT GETDATE(), 
    CONSTRAINT [PK_HOMEWORKCOMPLETE] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [HomeworkComplete_fk0] FOREIGN KEY ([HomeworkId]) REFERENCES [TrackingProgressInDevEducationDB].[Homeworks] ([id]),
    CONSTRAINT [HomeworkComplete_fk1] FOREIGN KEY ([StudentId]) REFERENCES [TrackingProgressInDevEducationDB].[Students] ([id])
);

