CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetCourseById](@id int)
AS
select id, [Name] from [Courses]
where [id] = @id
