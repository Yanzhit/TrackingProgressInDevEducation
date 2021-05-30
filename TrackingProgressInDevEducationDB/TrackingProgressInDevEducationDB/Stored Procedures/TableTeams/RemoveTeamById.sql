CREATE PROCEDURE [TrackingProgressInDevEducationDB].[RemoveTeamById](@id int)
AS 
delete from [TrackingProgressInDevEducationDB].[Teams]
where id=@id