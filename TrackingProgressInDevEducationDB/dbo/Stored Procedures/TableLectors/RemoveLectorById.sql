CREATE PROCEDURE [TrackingProgressInDevEducationDB].[RemoveLectorById](@ID int)
AS 
delete from [TrackingProgressInDevEducationDB].[Lectors]
where id=@ID
