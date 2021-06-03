CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyHWComplete]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[HomeworkComplete]
OUTPUT DELETED.Id
DBCC CHECKIDENT ([TrackingProgressInDevEducationDB.HomeworkComplete], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)