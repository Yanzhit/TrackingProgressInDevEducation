CREATE PROCEDURE [dbo].[UpdateHomeworkByid](@Name nvarchar(50), @ID int)
AS
update [dbo].[Homeworks] set Name=@Name
where id=@ID