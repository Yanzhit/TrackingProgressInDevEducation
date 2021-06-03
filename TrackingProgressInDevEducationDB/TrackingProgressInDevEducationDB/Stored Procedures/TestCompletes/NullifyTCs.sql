CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyTCs]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[TestComplete]
OUTPUT DELETED.Id
DBCC CHECKIDENT ([TrackingProgressInDevEducationDB.TestComplete], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)
