CREATE TABLE [TrackingProgressInDevEducationDB].[Lectors] (
    [id]       INT           IDENTITY (1, 1) NOT NULL,
    [FullName] NVARCHAR (50) NOT NULL,
    [Email] NVARCHAR (50) NULL, 
    [Password] NVARCHAR(50) NULL, 
    [IsActivated] BIT NOT NULL, 
    CONSTRAINT [PK_LECTORS] PRIMARY KEY CLUSTERED ([id] ASC)
);