CREATE TABLE [TrackingProgressInDevEducationDB].[Homework_Group] (
    [HomeworkId] INT NOT NULL,
    [GroupId]    INT NOT NULL,
    CONSTRAINT [Homework_Group_fk0] FOREIGN KEY ([HomeworkId]) REFERENCES [TrackingProgressInDevEducationDB].[Homeworks] ([id]),
    CONSTRAINT [Homework_Group_fk1] FOREIGN KEY ([GroupId]) REFERENCES [TrackingProgressInDevEducationDB].[Groups] ([id])
);

