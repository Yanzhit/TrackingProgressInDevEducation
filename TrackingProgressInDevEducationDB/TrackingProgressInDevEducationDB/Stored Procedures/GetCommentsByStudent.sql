CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetCommentsByStudent] 
@StudentId int
AS
	SELECT id, [Text] 
	FROM Comments
	WHERE StudentId = @StudentId