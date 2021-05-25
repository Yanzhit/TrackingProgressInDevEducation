CREATE PROCEDURE [dbo].[RemoveStudentById](@id int)
AS 
delete from [dbo].[Students]
where id=@id
