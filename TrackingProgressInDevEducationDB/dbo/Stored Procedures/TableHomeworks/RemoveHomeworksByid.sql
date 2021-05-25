CREATE PROCEDURE [dbo].[RemoveHomeworksByid](@ID int)
AS
delete from [dbo].[Homeworks]
where id=@ID
