CREATE PROCEDURE [dbo].[RemoveLectorById](@ID int)
AS 
delete from [dbo].[Lectors]
where id=@ID
