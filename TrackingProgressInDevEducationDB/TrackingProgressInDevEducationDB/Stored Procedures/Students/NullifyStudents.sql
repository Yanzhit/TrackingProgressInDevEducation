CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyStudents]
AS
delete from [TrackingProgressInDevEducationDB].[Students]
DBCC CHECKIDENT ([Students], RESEED, 0)  -- Обнуление ключа indentify