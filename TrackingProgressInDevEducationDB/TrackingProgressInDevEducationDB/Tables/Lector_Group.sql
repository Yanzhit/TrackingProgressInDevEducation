CREATE TABLE [TrackingProgressInDevEducationDB].[Lector_Group] (
    [LectorId] INT NOT NULL,
    [GroupId]  INT NOT NULL,
    CONSTRAINT [Lector_Group_fk0] FOREIGN KEY ([LectorId]) REFERENCES [TrackingProgressInDevEducationDB].[Lectors] ([id]),
    CONSTRAINT [Lector_Group_fk1] FOREIGN KEY ([GroupId]) REFERENCES [TrackingProgressInDevEducationDB].[Groups] ([id]), 
    CONSTRAINT [PK_Lector_Group] PRIMARY KEY ([LectorId], [GroupId])
);

