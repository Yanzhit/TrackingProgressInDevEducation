CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyCommentType]
AS
delete from [TrackingProgressInDevEducationDB].[CommentType]
DBCC CHECKIDENT ([CommentType], RESEED, 0)  -- Обнуление ключа indentify