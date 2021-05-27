CREATE PROCEDURE [TrackingProgressInDevEducationDB].[UpdateCommentById](@ID int, @Text nvarchar(50))
AS
update [TrackingProgressInDevEducationDB].[Comments] set Text=@Text
where id=@ID