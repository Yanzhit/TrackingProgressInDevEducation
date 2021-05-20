CREATE TABLE [dbo].[Lections] (
    [id]        INT      IDENTITY (1, 1) NOT NULL,
    [CourseId]  INT      NOT NULL,
    [LectorId]  INT      NOT NULL,
    [StartedOn] DATETIME NOT NULL,
    CONSTRAINT [PK_LECTIONS] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [Lection_fk0] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Groups] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [Lection_fk1] FOREIGN KEY ([LectorId]) REFERENCES [dbo].[Lectors] ([id]) ON UPDATE CASCADE
);

