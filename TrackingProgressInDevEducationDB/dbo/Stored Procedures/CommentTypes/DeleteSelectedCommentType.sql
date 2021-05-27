CREATE PROCEDURE [TrackingProgressInDevEducationDB].[DeleteSelectedCommentType]
	@ID int
AS
	DELETE FROM  [CommentType] 
	WHERE id = @ID
