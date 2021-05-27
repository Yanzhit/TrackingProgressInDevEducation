CREATE PROCEDURE [TrackingProgressInDevEducationDB].[RemoveCommentById](@ID int)
AS 
delete from [TrackingProgressInDevEducationDB].[Comments]
where id=@ID
