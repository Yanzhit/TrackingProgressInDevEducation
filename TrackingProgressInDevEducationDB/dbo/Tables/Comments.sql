CREATE TABLE [dbo].[Comments] (
    [Id]        INT          NOT NULL,
    [Name]      NVARCHAR (1) NOT NULL,
    [TypeId]    INT          NOT NULL,
    [StudentId] INT          NOT NULL,
    [CreatedBy] INT          NOT NULL,
    CONSTRAINT [PK_COMMENTS] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [Comment_fk0] FOREIGN KEY ([TypeId]) REFERENCES [dbo].[CommentType] ([Id]) ON UPDATE CASCADE,
    CONSTRAINT [Comment_fk1] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Students] ([Id]) ON UPDATE CASCADE,
    CONSTRAINT [Comment_fk2] FOREIGN KEY ([CreatedBy]) REFERENCES [dbo].[Lectors] ([Id]) ON UPDATE CASCADE
);

