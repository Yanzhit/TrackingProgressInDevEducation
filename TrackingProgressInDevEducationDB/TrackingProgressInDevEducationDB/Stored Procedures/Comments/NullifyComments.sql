CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyComments]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Comments]
DBCC CHECKIDENT ([Comments], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)