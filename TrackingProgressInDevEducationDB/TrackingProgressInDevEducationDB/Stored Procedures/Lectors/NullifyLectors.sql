CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyLectors]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Lectors]
DBCC CHECKIDENT ([Lectors], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)