CREATE TABLE [dbo].[Courses] (
    [id]         INT           IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (50) NOT NULL,
    [StartedOn]  DATE          NOT NULL,
    [FinishedOn] DATE          NULL,
    CONSTRAINT [PK_COURSES] PRIMARY KEY CLUSTERED ([id] ASC)
);

