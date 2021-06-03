CREATE PROCEDURE [TrackingProgressInDevEducationDB].[UpdDStudentToGroup]
	@StudentId int,
	@GroupId int
AS
	UPDATE Students SET GroupId = @GroupId
	OUTPUT DELETED.Id
    WHERE id = @StudentId