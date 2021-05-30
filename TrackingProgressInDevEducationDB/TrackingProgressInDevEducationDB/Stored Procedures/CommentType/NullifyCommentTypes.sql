CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyCommentType]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[CommentType]
DBCC CHECKIDENT ([CommentType], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)