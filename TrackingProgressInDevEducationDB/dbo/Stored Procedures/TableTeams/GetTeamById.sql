CREATE PROCEDURE [dbo].[GetTeamById](@id int)
AS 
select * from [Teams]
where id=@id
