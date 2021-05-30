CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyHomeworkComplete]
AS
delete from [TrackingProgressInDevEducationDB].[HomeworkComplete]
DBCC CHECKIDENT ([HomeworkComplete], RESEED, 0)  -- Обнуление ключа indentify