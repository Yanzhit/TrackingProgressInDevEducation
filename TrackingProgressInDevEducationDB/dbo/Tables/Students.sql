CREATE TABLE [dbo].[Students] (
    [id]      INT            IDENTITY (1, 1) NOT NULL,
    [Name]    NVARCHAR (50)  NOT NULL,
    [Surname] NVARCHAR (50)  NOT NULL,
    [Rate]    DECIMAL (6, 2) NOT NULL,
    CONSTRAINT [PK_STUDENTS] PRIMARY KEY CLUSTERED ([id] ASC)
);

