CREATE TABLE [TrackingProgressInDevEducationDB].[Teams] (
    [id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (50) NOT NULL,
    [From] NVARCHAR(50) NULL, 
    [To] NVARCHAR(50) NULL, 
    [LectorId] INT NULL, 
    CONSTRAINT [PK_TEAMS] PRIMARY KEY CLUSTERED ([id] ASC), 
    CONSTRAINT [FK_Teams_ToLector] FOREIGN KEY ([LectorId]) REFERENCES [TrackingProgressInDevEducationDB].[Lectors]([id])
);

