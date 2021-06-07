CREATE TABLE [TrackingProgressInDevEducationDB].[Lections] (
    [id]        INT      IDENTITY (1, 1) NOT NULL,
    [GroupId]  INT      NOT NULL,
    [LectorId]  INT      NOT NULL,
    [StartedOn] NVARCHAR(50) NOT NULL,
    CONSTRAINT [PK_LECTIONS] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [Lection_fk0] FOREIGN KEY ([GroupId]) REFERENCES [TrackingProgressInDevEducationDB].[Groups] ([id]),
    CONSTRAINT [Lection_fk1] FOREIGN KEY ([LectorId]) REFERENCES [TrackingProgressInDevEducationDB].[Lectors] ([id])
);