CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyLections]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Lections]
OUTPUT DELETED.Id
DBCC CHECKIDENT ([TrackingProgressInDevEducationDB.Lections], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)