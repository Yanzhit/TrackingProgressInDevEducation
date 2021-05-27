CREATE PROCEDURE [dbo].[RemoveHomeworksByid](@id int)
AS
delete from [dbo].[Homeworks]
where id=@id
