CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetHWById](@id int)
AS
select * from [Homeworks] 
where id=@id