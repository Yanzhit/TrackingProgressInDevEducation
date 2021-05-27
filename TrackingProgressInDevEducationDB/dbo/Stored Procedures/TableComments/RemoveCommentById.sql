CREATE PROCEDURE [dbo].[RemoveCommentById](@id int)
AS 
delete from [dbo].[Comments]
where id=@id
