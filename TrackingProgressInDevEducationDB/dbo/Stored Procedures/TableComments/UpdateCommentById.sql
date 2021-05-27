CREATE PROCEDURE [dbo].[UpdateCommentById](@id int, @Text nvarchar(50))
AS
update [dbo].[Comments] set Text=@Text
where id=@id