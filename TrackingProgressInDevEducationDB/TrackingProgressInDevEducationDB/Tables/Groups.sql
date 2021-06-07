CREATE TABLE [TrackingProgressInDevEducationDB].[Groups] (
    [id]       INT           IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (50) NOT NULL,
    [CourseId] INT           NOT NULL,
    [StartDate] NVARCHAR(50) NOT NULL, 
    [EndDate] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_GROUPS] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [Group_fk0] FOREIGN KEY ([CourseId]) REFERENCES [TrackingProgressInDevEducationDB].[Courses] ([id])
);

