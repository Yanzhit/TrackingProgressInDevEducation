CREATE TABLE [dbo].[Homework_Group] (
    [HomeworkId] INT NOT NULL,
    [GroupId]    INT NOT NULL,
    CONSTRAINT [Homework_Group_fk0] FOREIGN KEY ([HomeworkId]) REFERENCES [dbo].[Homeworks] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [Homework_Group_fk1] FOREIGN KEY ([GroupId]) REFERENCES [dbo].[Groups] ([id]) ON UPDATE CASCADE
);

