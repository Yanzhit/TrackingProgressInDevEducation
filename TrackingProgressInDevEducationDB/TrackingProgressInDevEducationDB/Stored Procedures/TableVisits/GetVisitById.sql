CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetVisitById](@id int)
AS 
select * from [Visits]
where id=@id