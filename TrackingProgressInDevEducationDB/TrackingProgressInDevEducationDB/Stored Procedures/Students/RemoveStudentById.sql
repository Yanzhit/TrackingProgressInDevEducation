CREATE PROCEDURE [TrackingProgressInDevEducationDB].[RemoveStudentById](@id int)
AS 
delete from [TrackingProgressInDevEducationDB].[Students]
where id=@id