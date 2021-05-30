CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyTeamStudent]
AS
delete from [TrackingProgressInDevEducationDB].[Team_Student]
DBCC CHECKIDENT ([Team_Student], RESEED, 0)  -- Обнуление ключа indentify