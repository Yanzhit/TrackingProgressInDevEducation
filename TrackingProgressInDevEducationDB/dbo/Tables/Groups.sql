CREATE TABLE [dbo].[Groups] (
    [Id]       INT          NOT NULL,
    [Name]     NVARCHAR (1) NOT NULL,
    [CourseId] INT          NOT NULL,
    CONSTRAINT [PK_GROUPS] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [Group_fk0] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Courses] ([Id]) ON UPDATE CASCADE
);

