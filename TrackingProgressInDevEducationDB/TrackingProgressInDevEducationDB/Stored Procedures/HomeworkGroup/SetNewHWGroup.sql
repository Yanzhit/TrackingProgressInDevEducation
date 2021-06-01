CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewHWGroup]
(
	 @HomeworkId INT
	,@GroupId INT
)
AS
	INSERT [Homework_Group]
	(
		 [HomeworkId]
		,[GroupId]
	)
	VALUES
	(
		 @HomeworkId
		,@GroupId		
	)
--ZLoo (Все ок)