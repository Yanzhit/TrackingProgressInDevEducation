CREATE PROCEDURE [TrackingProgressInDevEducationDB].[RemoveGroupById](@ID int)
AS 
delete from [TrackingProgressInDevEducationDB].[Groups]
where id=@ID
