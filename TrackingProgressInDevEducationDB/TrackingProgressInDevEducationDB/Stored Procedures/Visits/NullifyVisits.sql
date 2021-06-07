CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyVisits]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Visits]
OUTPUT DELETED.[id]
DBCC CHECKIDENT ([TrackingProgressInDevEducationDB.Visits], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)