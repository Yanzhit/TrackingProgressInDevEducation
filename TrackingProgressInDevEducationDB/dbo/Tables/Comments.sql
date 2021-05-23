CREATE TABLE [dbo].[Comments] (
    [id]        INT           IDENTITY (1, 1) NOT NULL,
    [Text]      NVARCHAR (50) NOT NULL,
    [TypeId]    INT           NOT NULL,
    [StudentId] INT           NOT NULL,
    [CreatedBy] INT           NOT NULL,
    CONSTRAINT [PK_COMMENTS] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [Comment_fk0] FOREIGN KEY ([TypeId]) REFERENCES [dbo].[CommentType] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [Comment_fk1] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Students] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [Comment_fk2] FOREIGN KEY ([CreatedBy]) REFERENCES [dbo].[Lectors] ([id]) ON UPDATE CASCADE
);

