CREATE PROCEDURE [dbo].[RemoveHomeworksById](@id int)
AS
delete from [dbo].[Homeworks]
where id=@id
