CREATE PROCEDURE [TrackingProgressInDevEducationDB].[RemoveGroupById](@id int)
AS 
delete from [TrackingProgressInDevEducationDB].[Groups]
where id=@id