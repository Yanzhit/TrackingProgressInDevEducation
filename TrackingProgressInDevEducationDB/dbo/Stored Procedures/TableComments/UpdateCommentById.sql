CREATE PROCEDURE [dbo].[UpdateCommentById](@ID int, @Text nvarchar(50))
AS
update [dbo].[Comments] set Text=@Text
where id=@ID