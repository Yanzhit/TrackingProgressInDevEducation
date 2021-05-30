CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyStudents]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Students]
DBCC CHECKIDENT ([Students], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)