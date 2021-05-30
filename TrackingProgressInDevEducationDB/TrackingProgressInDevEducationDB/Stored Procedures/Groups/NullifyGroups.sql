CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyGroups]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Groups]
DBCC CHECKIDENT ([Groups], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)