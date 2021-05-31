CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetTeamById](@id int)
AS 
select * from [Teams]
where id=@id