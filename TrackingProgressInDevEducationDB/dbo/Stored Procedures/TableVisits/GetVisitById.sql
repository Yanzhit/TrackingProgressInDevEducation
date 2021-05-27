CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetVisitById](@ID int)
AS 
select * from [Visits]
where id=@ID