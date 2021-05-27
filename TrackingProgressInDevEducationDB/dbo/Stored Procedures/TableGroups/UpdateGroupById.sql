CREATE PROCEDURE [dbo].[UpdateGroupById](@id int, @Name nvarchar(50), @CourseId int)
AS 
update [dbo].[Groups] set [Name]=@Name, CourseId=@CourseId	--???
where id=@id