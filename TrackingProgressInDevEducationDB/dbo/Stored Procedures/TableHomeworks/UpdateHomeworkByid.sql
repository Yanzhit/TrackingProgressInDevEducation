CREATE PROCEDURE [dbo].[UpdateHomeworkById](@Name nvarchar(50), @id int)
AS
update [dbo].[Homeworks] set Name=@Name
where id=@id