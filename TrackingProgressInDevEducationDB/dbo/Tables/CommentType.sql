CREATE TABLE [TrackingProgressInDevEducationDB].[CommentType] (
    [id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_COMMENTTYPE] PRIMARY KEY CLUSTERED ([id] ASC)
);

