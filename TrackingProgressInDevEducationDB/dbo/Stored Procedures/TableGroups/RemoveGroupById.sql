CREATE PROCEDURE [dbo].[RemoveGroupById](@id int)
AS 
delete from [dbo].[Groups]
where id=@id
