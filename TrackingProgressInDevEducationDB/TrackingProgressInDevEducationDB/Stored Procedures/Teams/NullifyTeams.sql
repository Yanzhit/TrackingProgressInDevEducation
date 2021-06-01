CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyTeams]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Teams]
DBCC CHECKIDENT ([Teams], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)