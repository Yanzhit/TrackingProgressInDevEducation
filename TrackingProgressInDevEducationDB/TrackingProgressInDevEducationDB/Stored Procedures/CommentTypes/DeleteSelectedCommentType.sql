CREATE PROCEDURE [TrackingProgressInDevEducationDB].[DeleteSelectedCommentType]
	@id int
AS
	DELETE FROM  [CommentType] 
	WHERE id = @id