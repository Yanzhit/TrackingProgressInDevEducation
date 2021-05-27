CREATE PROCEDURE [dbo].[GetGroupById](@id int)
AS 
select * from [Groups]
where id=@id