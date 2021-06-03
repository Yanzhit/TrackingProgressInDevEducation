CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyComments]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Comments]
OUTPUT DELETED.Id
DBCC CHECKIDENT ([TrackingProgressInDevEducationDB.Comments], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)