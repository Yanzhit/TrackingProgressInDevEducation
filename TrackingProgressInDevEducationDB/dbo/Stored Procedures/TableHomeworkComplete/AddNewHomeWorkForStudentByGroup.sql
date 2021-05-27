CREATE PROCEDURE [TrackingProgressInDevEducationDB].[AddNewHomeWorkForStudentByGroup]
	@HomeWork int,
	@Group int
AS
	INSERT HomeworkComplete 
	SELECT @HomeWork, id, 0 -- filling fields
	FROM Students
	WHERE GroupId = @Group
