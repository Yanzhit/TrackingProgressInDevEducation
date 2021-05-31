CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyCType]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[CommentType]
DBCC CHECKIDENT ([CommentType], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)