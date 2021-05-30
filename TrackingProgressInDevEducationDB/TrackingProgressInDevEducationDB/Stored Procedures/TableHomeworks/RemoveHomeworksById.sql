CREATE PROCEDURE [TrackingProgressInDevEducationDB].[RemoveHomeworksById](@id int)
AS
delete from [TrackingProgressInDevEducationDB].[Homeworks]
where id=@id