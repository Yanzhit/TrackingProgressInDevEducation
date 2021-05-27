CREATE PROCEDURE [dbo].[UpdateCommentTypeById]
	@ID int,
	@Name nvarchar

AS
	UPDATE [dbo].[CommentType] 
	SET [Name] = @Name WHERE id = @ID 
