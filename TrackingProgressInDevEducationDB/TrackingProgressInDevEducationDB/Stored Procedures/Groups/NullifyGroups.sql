CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyGroups]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Groups]
OUTPUT DELETED.id
DBCC CHECKIDENT ([TrackingProgressInDevEducationDB.Groups], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)