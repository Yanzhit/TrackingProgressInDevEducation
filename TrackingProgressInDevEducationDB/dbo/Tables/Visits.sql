CREATE TABLE [TrackingProgressInDevEducationDB].[Visits] (
    [id]          INT IDENTITY (1, 1) NOT NULL,
    [VisitStatus] BIT NOT NULL,
    [StudentId]   INT NOT NULL,
    [LectionId]   INT NOT NULL,
    CONSTRAINT [PK_VISITS] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [Visit_fk0] FOREIGN KEY ([StudentId]) REFERENCES [TrackingProgressInDevEducationDB].[Students] ([id]),
    CONSTRAINT [Visit_fk1] FOREIGN KEY ([LectionId]) REFERENCES [TrackingProgressInDevEducationDB].[Lections] ([id])
);

