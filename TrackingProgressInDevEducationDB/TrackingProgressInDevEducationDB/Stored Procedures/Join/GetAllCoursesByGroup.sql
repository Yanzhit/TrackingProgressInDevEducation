CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetAllCoursesByGroup]
	@GroupId int
AS
	SELECT C.Name, C.Description
	FROM Courses C
	Left JOIN [TrackingProgressInDevEducationDB].Groups G ON G.CourseId = C.id
	WHERE G.id = @GroupId
