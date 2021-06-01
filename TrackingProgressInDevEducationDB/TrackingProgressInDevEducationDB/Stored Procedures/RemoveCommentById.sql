CREATE PROCEDURE [TrackingProgressInDevEducationDB].[RemoveCommentById](@id int)
AS 
delete from [TrackingProgressInDevEducationDB].[Comments]
where id=@id