CREATE PROCEDURE [dbo].[AddCourseToLector]
	@LectorId int,
	@CourseId int
AS
	Insert [Lector_Courses]
	VALUES (@LectorId, @CourseId)