CREATE TABLE [dbo].[Lections] (
    [Id]        INT      NOT NULL,
    [CourseId]  INT      NOT NULL,
    [LectorId]  INT      NOT NULL,
    [StartedOn] DATETIME NOT NULL,
    CONSTRAINT [PK_LECTIONS] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [Lection_fk0] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Groups] ([Id]) ON UPDATE CASCADE,
    CONSTRAINT [Lection_fk1] FOREIGN KEY ([LectorId]) REFERENCES [dbo].[Lectors] ([Id]) ON UPDATE CASCADE
);

