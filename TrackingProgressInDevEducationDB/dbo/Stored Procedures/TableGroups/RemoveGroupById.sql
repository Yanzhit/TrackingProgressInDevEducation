CREATE PROCEDURE [dbo].[RemoveGroupById](@ID int)
AS 
delete from [dbo].[Groups]
where id=@ID
