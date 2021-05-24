CREATE PROCEDURE [dbo].[RemoveCommentById](@ID int)
AS 
delete from [dbo].[Comments]
where id=@ID
