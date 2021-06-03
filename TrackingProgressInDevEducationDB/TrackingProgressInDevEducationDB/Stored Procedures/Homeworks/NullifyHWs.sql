CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyHWs]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Homeworks]
OUTPUT DELETED.Id
DBCC CHECKIDENT ([TrackingProgressInDevEducationDB.Homeworks], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)