CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyTests]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Tests]
OUTPUT DELETED.Id
DBCC CHECKIDENT ([TrackingProgressInDevEducationDB.Tests], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)