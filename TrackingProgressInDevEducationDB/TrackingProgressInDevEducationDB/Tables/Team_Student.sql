CREATE TABLE [TrackingProgressInDevEducationDB].[Team_Student] (
    [TeamId]    INT NOT NULL,
    [StudentId] INT NOT NULL,
    CONSTRAINT [Team_Student_fk0] FOREIGN KEY ([TeamId]) REFERENCES [TrackingProgressInDevEducationDB].[Teams] ([id]),
    CONSTRAINT [Team_Student_fk1] FOREIGN KEY ([StudentId]) REFERENCES [TrackingProgressInDevEducationDB].[Students] ([id]), 
    CONSTRAINT [PK_Team_Student] PRIMARY KEY ([TeamId], [StudentId])
);

