CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyHWComplete]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[HomeworkComplete]
DBCC CHECKIDENT ([HomeworkComplete], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)