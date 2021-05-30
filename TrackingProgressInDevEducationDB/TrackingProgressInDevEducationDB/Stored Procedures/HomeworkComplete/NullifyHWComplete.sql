CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyHWComplete]
AS
delete from [TrackingProgressInDevEducationDB].[HomeworkComplete]
DBCC CHECKIDENT ([HomeworkComplete], RESEED, 0)  -- Обнуление ключа indentify