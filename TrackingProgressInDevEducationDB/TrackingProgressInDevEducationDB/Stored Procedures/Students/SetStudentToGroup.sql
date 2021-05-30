CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetStudentToGroup]
	@StudentId int,
	@GroupId int
AS
	UPDATE Students SET GroupId = @GroupId
    WHERE id = @StudentId