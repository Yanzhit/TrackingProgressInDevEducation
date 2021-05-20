CREATE TABLE [dbo].[Courses] (
    [Id]         INT          NOT NULL,
    [Name]       NVARCHAR (1) NOT NULL,
    [StartedOn]  DATE         NOT NULL,
    [FinishedOn] DATE         NULL,
    CONSTRAINT [PK_COURSES] PRIMARY KEY CLUSTERED ([Id] ASC)
);

