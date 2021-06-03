CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyGroups]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Groups]
OUTPUT DELETED.Id
DBCC CHECKIDENT ([TrackingProgressInDevEducationDB.Groups], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)