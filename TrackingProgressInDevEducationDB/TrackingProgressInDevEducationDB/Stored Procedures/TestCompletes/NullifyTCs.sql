CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyTCs]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[TestComplete]
DBCC CHECKIDENT ([TestComplete], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)
