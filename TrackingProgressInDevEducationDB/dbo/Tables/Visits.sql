CREATE TABLE [dbo].[Visits] (
    [id]          INT IDENTITY (1, 1) NOT NULL,
    [VisitStatus] BIT NOT NULL,
    [StudentId]   INT NOT NULL,
    [LectionId]   INT NOT NULL,
    CONSTRAINT [PK_VISITS] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [Visit_fk0] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Students] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [Visit_fk1] FOREIGN KEY ([LectionId]) REFERENCES [dbo].[Lections] ([id]) ON UPDATE CASCADE
);

