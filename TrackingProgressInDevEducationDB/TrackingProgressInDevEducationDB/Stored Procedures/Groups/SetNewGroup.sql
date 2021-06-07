CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewGroup]
(
	 @Name NVARCHAR(50)
	,@CourseId INT
	,@StartDate DATE
	,@EndDate DATE
)
AS 
	IF @StartDate = null SET @StartDate = GetDate()
	INSERT [Groups]
	(
		 [Name]
		,[CourseId]
		,[StartDate]
		,[EndDate]
	)
	OUTPUT INSERTED.id, INSERTED.[Name], INSERTED.CourseId, INSERTED.StartDate, INSERTED.EndDate
	VALUES
	(
		 @Name
		,@CourseId
		,@StartDate
		,@EndDate
	)
--ZLoo (Все ок)