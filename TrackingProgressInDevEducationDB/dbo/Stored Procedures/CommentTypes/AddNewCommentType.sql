CREATE PROCEDURE [dbo].[AddNewCommentType]
	@Name nvarchar
AS
	INSERT [CommentType] (Name)
	VALUES (@Name)
