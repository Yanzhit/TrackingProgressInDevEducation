CREATE PROCEDURE [dbo].[UpdateCourseById](@id int, @Name nvarchar(50), @StartedOn date, @FinishedOn date)
AS
update [dbo].[Courses] set Name=@Name, StartedOn=@StartedOn, FinishedOn=@FinishedOn	
where id=@id
