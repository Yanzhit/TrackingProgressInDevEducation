CREATE TABLE [TrackingProgressInDevEducationDB].[Comments] (
    [id]        INT           IDENTITY (1, 1) NOT NULL,
    [Text]      NVARCHAR (250) NOT NULL,
    [TypeId]    INT           NOT NULL,
    [StudentId] INT           NULL,
    [CreatedBy] INT           NOT NULL,
    [TeamId] INT NULL, 
    [CommentFor] INT NOT NULL, 
    [Estimation] INT  NULL, 
    CONSTRAINT [PK_COMMENTS] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [Comment_fk0] FOREIGN KEY ([TypeId]) REFERENCES [TrackingProgressInDevEducationDB].[CommentType] ([id]),
    CONSTRAINT [Comment_fk1] FOREIGN KEY ([StudentId]) REFERENCES [TrackingProgressInDevEducationDB].[Students] ([id]),
    CONSTRAINT [Comment_fk2] FOREIGN KEY ([CreatedBy]) REFERENCES [TrackingProgressInDevEducationDB].[Lectors] ([id]), 
    CONSTRAINT [Comment_fk3] FOREIGN KEY ([TeamId]) REFERENCES [TrackingProgressInDevEducationDB].[Teams]([id]), 
    CONSTRAINT [Comment_fk4] FOREIGN KEY ([CommentFor]) REFERENCES [TrackingProgressInDevEducationDB].[CommentFor]([id])
);