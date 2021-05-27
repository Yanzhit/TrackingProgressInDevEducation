CREATE PROCEDURE [TrackingProgressInDevEducationDB].[UpdateGroupById](@ID int, @Name nvarchar(50), @CourseId int)
AS 
update [TrackingProgressInDevEducationDB].[Groups] set [Name]=@Name, CourseId=@CourseId	--???
where id=@ID