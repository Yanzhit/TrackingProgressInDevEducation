CREATE TABLE [dbo].[Students] (
    [Id]      INT          NOT NULL,
    [Name]    NVARCHAR (1) NOT NULL,
    [Surname] NVARCHAR (1) NOT NULL,
    [Rate]    DECIMAL (18) NOT NULL,
    CONSTRAINT [PK_STUDENTS] PRIMARY KEY CLUSTERED ([Id] ASC)
);

