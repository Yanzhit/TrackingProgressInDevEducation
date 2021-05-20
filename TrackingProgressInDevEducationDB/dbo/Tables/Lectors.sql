CREATE TABLE [dbo].[Lectors] (
    [id]       INT           IDENTITY (1, 1) NOT NULL,
    [FullName] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_LECTORS] PRIMARY KEY CLUSTERED ([id] ASC)
);

