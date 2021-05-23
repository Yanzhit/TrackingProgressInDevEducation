CREATE PROCEDURE [dbo].[RemoveCourseById](@id int)
AS 
delete from [dbo].[Courses]
where id=@id

