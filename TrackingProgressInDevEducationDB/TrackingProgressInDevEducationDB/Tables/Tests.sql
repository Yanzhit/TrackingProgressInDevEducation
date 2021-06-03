CREATE TABLE [TrackingProgressInDevEducationDB].[Tests]
(
	[Id] INT IDENTITY (1, 1) NOT NULL, 
    [Name] NCHAR(50) NULL, 
    [Description] NCHAR(50) NULL
    CONSTRAINT [PK_TESTS] PRIMARY KEY CLUSTERED ([id] ASC),
)
