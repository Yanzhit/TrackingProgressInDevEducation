CREATE PROCEDURE [TrackingProgressInDevEducationDB].[RemoveHWById](@id int)
AS
delete from [TrackingProgressInDevEducationDB].[Homeworks]
where id=@id