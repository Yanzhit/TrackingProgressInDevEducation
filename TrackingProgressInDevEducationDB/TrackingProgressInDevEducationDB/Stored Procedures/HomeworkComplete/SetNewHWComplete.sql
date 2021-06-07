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
	OUTPUT INSERTED.id, INSERTED.HomeworkId, INSERTED.StudentId, INSERTED.[Status]
	VALUES
	(
		 @HomeworkId
		,@StudentId
		,@Status
	)	
--ZLoo (Все ок)