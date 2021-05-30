CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewCourseToLector]
	@LectorId int,
	@CourseId int
AS
	Insert [Lector_Courses]
	VALUES (@LectorId, @CourseId)