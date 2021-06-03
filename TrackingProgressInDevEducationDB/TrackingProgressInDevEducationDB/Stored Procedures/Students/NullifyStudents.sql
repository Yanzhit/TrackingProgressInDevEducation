CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyStudents]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Students]
OUTPUT DELETED.Id
DBCC CHECKIDENT ([TrackingProgressInDevEducationDB.Students], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)