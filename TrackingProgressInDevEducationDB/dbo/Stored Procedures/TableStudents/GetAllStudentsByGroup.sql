CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetAllStudentsByGroup]
	@GroupId int
AS
	SELECT *
	FROM Students
	WhERE GroupId = @GroupId
