CREATE PROCEDURE [TrackingProgressInDevEducationDB].[RemoveLectorById](@id int)
AS 
delete from [TrackingProgressInDevEducationDB].[Lectors]
where id=@id