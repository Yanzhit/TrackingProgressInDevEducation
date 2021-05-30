CREATE PROCEDURE [TrackingProgressInDevEducationDB].[UpdateCommentById](@id int, @Text nvarchar(50))
AS
update [TrackingProgressInDevEducationDB].[Comments] set Text=@Text
where id=@id