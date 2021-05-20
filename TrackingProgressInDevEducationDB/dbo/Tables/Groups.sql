CREATE TABLE [dbo].[Groups] (
    [id]       INT           IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (50) NOT NULL,
    [CourseId] INT           NOT NULL,
    CONSTRAINT [PK_GROUPS] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [Group_fk0] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Courses] ([id]) ON UPDATE CASCADE
);

