CREATE TABLE [TrackingProgressInDevEducationDB].[Students] (
    [id]      INT            IDENTITY (1, 1) NOT NULL,
    [Name]    NVARCHAR (50)  NULL,
    [Surname] NVARCHAR (50)  NULL,
    [Rate]    DECIMAL (6, 2) NULL,
    [GroupId] INT NULL, 
    [Phone] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(50) NULL, 
    [Contract] NVARCHAR(50) NULL, 
    [Birthday] NVARCHAR(50) NULL, 
    [MiddleName] NVARCHAR(50) NULL, 
    [Git] NVARCHAR(50) NULL, 
    [CityId] INT NULL, 
    [Status] BIT NULL, 
    CONSTRAINT [PK_STUDENTS] PRIMARY KEY CLUSTERED ([id] ASC), 
    CONSTRAINT [FK_Students_Group] FOREIGN KEY ([GroupId]) REFERENCES [TrackingProgressInDevEducationDB].[Groups]([id]),
    CONSTRAINT [FK_Students_City] FOREIGN KEY ([CityId]) REFERENCES [TrackingProgressInDevEducationDB].[Cities]([id])
);

