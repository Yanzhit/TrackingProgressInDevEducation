CREATE TABLE [dbo].[Lector_Group] (
    [LectorId] INT NOT NULL,
    [GroupId]  INT NOT NULL,
    CONSTRAINT [Lector_Group_fk0] FOREIGN KEY ([LectorId]) REFERENCES [dbo].[Lectors] ([Id]) ON UPDATE CASCADE,
    CONSTRAINT [Lector_Group_fk1] FOREIGN KEY ([GroupId]) REFERENCES [dbo].[Groups] ([Id]) ON UPDATE CASCADE
);

