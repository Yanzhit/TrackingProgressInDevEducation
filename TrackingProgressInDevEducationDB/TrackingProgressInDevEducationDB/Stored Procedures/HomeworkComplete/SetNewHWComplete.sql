CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewHWComplete]
(
	 @HomeworkId INT
	,@StudentId INT
	,@Status BIT
)
AS
	INSERT [HomeworkComplete]
	(
		 [HomeworkId]
		,[StudentId]
		,[Status]
	)
	OUTPUT INSERTED.Id
	VALUES
	(
		 @HomeworkId
		,@StudentId
		,@Status
	)	
--ZLoo (Все ок)