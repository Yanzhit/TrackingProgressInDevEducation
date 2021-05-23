CREATE PROCEDURE [dbo].[GetCourseById](@id int)
AS
select [Name], [StartedOn], [FinishedOn] from [Courses]
where [id] = @id
