CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyCFor]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[CommentFor]
OUTPUT DELETED.id
DBCC CHECKIDENT ([TrackingProgressInDevEducationDB.CommentFor], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)
