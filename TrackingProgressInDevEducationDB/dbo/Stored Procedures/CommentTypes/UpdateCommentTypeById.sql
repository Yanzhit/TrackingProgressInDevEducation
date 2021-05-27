CREATE PROCEDURE [TrackingProgressInDevEducationDB].[UpdateCommentTypeById]
	@ID int,
	@Name nvarchar

AS
	UPDATE [TrackingProgressInDevEducationDB].[CommentType] 
	SET [Name] = @Name WHERE id = @ID 
