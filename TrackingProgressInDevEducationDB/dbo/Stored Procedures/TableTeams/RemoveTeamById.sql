CREATE PROCEDURE [dbo].[RemoveTeamById](@id int)
AS 
delete from [dbo].[Teams]
where id=@id