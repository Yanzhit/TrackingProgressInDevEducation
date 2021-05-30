CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyVisits]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Visits]
DBCC CHECKIDENT ([Visits], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)