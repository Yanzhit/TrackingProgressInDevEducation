CREATE PROCEDURE [dbo].[GetGroupById](@ID int)
AS 
select * from [Groups]
where id=@ID