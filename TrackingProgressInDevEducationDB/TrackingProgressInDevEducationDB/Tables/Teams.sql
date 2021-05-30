CREATE TABLE [TrackingProgressInDevEducationDB].[Teams] (
    [id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (50) NOT NULL,
    [From] DATE NULL, 
    [To] Date NULL, 
    CONSTRAINT [PK_TEAMS] PRIMARY KEY CLUSTERED ([id] ASC)
);

