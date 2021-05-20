CREATE TABLE [dbo].[Visits] (
    [Id]          INT NOT NULL,
    [VisitStatus] BIT NOT NULL,
    [StudentId]   INT NOT NULL,
    [LectionId]   INT NOT NULL,
    CONSTRAINT [PK_VISITS] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [Visit_fk0] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Students] ([Id]) ON UPDATE CASCADE,
    CONSTRAINT [Visit_fk1] FOREIGN KEY ([LectionId]) REFERENCES [dbo].[Lections] ([Id]) ON UPDATE CASCADE
);

