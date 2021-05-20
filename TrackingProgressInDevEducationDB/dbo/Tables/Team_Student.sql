CREATE TABLE [dbo].[Team_Student] (
    [TeamId]    INT NOT NULL,
    [StudentId] INT NOT NULL,
    CONSTRAINT [Team_Student_fk0] FOREIGN KEY ([TeamId]) REFERENCES [dbo].[Teams] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [Team_Student_fk1] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Students] ([id]) ON UPDATE CASCADE
);

