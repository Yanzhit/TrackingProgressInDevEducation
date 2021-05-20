CREATE TABLE [dbo].[HomeworkComplete] (
    [Id]         INT NOT NULL,
    [HomeworkId] INT NOT NULL,
    [StudentId]  INT NOT NULL,
    [Status]     BIT NOT NULL,
    CONSTRAINT [PK_HOMEWORKCOMPLETE] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [HomeworkComplete_fk0] FOREIGN KEY ([HomeworkId]) REFERENCES [dbo].[Homeworks] ([Id]) ON UPDATE CASCADE,
    CONSTRAINT [HomeworkComplete_fk1] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Students] ([Id]) ON UPDATE CASCADE
);

