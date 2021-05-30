CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetAllCoursesByLector]
	@LectorId int
AS
	SELECT C.id, C.[Name]
	FROM Courses C
	LEFT JOIN Lector_Courses LC ON C.id = LC.CourseId
	LEFT JOIN Lectors L ON LC.LectorId = L.id
	WHERE L.id = @LectorId