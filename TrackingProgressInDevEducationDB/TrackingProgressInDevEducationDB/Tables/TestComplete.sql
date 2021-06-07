CREATE TABLE [TrackingProgressInDevEducationDB].[TestComplete]
(
	[id] INT IDENTITY (1, 1) NOT NULL,
    [TestId] INT NOT NULL,
	[StudentId]  INT NOT NULL,
    [Status]     BIT NOT NULL,
    [ApproveDate] NVARCHAR(50) NULL, 
    [Score] INT NULL,
	CONSTRAINT [PK_TESTCOMPLETE] PRIMARY KEY CLUSTERED ([id] ASC), 
    CONSTRAINT [TestComplete_fk0] FOREIGN KEY ([TestId]) REFERENCES [TrackingProgressInDevEducationDB].[Tests] ([id]),
    CONSTRAINT [TestComplete_fk1] FOREIGN KEY ([StudentId]) REFERENCES [TrackingProgressInDevEducationDB].[Students] ([id])
)
