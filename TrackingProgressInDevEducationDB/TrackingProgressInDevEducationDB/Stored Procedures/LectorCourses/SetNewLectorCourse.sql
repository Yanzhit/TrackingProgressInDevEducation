CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewLectorCourse]
(
	 @LectorId INT
	,@CourseId INT
)
AS
	INSERT [Lector_Courses]
	(
		 [LectorId]
		,[CourseId]
	)
	OUTPUT INSERTED.LectorId, INSERTED.CourseId
	VALUES
	(
		 @LectorId
		,@CourseId
	)
--ZLoo (Все ок)