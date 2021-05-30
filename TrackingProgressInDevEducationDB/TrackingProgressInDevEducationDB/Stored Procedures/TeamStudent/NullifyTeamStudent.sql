CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyTeamStudent]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Team_Student]
DBCC CHECKIDENT ([Team_Student], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)