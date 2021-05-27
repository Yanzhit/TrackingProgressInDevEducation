CREATE PROCEDURE [TrackingProgressInDevEducationDB].[RemoveHomeworksByid](@ID int)
AS
delete from [TrackingProgressInDevEducationDB].[Homeworks]
where id=@ID
