CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyLections]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Lections]
DBCC CHECKIDENT ([Lections], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)