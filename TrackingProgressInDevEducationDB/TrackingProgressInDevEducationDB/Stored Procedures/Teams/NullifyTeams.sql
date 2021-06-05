CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyTeams]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Teams]
OUTPUT DELETED.id
DBCC CHECKIDENT ([TrackingProgressInDevEducationDB.Teams], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)