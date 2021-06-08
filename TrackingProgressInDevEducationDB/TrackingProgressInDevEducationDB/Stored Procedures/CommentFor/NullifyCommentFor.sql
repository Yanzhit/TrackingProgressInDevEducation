CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyCommentFor]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[CommentFor]
OUTPUT DELETED.id
DBCC CHECKIDENT ([TrackingProgressInDevEducationDB.CommentFor], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)
