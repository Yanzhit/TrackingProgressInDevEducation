CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyLectors]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Lectors]
OUTPUT DELETED.id
DBCC CHECKIDENT ([TrackingProgressInDevEducationDB.Lectors], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)