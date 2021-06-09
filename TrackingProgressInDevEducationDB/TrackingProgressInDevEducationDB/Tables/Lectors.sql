CREATE TABLE [TrackingProgressInDevEducationDB].[Lectors] (
    [id]       INT           IDENTITY (1, 1) NOT NULL,
    [Login] NVARCHAR (50) NULL,
    [FullName] NVARCHAR (50) NOT NULL,
    [Email] NVARCHAR (50) NULL, 
    [Password] NVARCHAR(50) NULL, 
    [IsActivated] BIT NULL, 
    CONSTRAINT [PK_LECTORS] PRIMARY KEY CLUSTERED ([id] ASC)
);