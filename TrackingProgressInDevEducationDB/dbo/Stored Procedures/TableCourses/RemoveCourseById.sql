CREATE PROCEDURE [TrackingProgressInDevEducationDB].[RemoveCourseById](@id int)
AS 
delete from [TrackingProgressInDevEducationDB].[Courses]
where id=@id

