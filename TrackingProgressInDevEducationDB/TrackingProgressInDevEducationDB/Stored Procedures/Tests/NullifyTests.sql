CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyTests]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Tests]
OUTPUT DELETED.id
DBCC CHECKIDENT ([TrackingProgressInDevEducationDB.Tests], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)