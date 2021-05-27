CREATE PROCEDURE [TrackingProgressInDevEducationDB].[RemoveVisitById](@ID int)
AS 
delete from [TrackingProgressInDevEducationDB].[Visits]
where id=@ID