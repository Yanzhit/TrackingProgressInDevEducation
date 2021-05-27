CREATE PROCEDURE [TrackingProgressInDevEducationDB].[UpdateCommentTypeById]
	@id int,
	@Name nvarchar
AS
	UPDATE [TrackingProgressInDevEducationDB].[CommentType] 
	SET [Name] = @Name WHERE id = @id 
