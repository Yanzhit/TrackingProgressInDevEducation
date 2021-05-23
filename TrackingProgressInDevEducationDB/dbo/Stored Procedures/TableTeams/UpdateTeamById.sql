CREATE PROCEDURE [dbo].[UpdateTeamById](@id int,@Name nvarchar(50))
AS 
update [dbo].[Teams] set [Name]=@Name
where id=@id
