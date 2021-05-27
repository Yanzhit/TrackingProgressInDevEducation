CREATE PROCEDURE [TrackingProgressInDevEducationDB].[RemoveVisitById](@id int)
AS 
delete from [TrackingProgressInDevEducationDB].[Visits]
where id=@id