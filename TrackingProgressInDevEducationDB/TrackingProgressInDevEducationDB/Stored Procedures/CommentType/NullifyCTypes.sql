CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyCType]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[CommentType]
OUTPUT DELETED.Id
DBCC CHECKIDENT ([TrackingProgressInDevEducationDB.CommentType], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)