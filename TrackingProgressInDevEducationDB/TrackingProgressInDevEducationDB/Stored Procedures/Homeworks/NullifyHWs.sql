CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyHWs]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Homeworks]
DBCC CHECKIDENT ([Homeworks], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)