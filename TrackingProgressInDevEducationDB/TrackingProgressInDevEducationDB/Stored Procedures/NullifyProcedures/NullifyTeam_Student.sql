CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyTeam_Student]
AS
delete from [TrackingProgressInDevEducationDB].[Team_Student]
DBCC CHECKIDENT ([Team_Student], RESEED, 0)  -- Обнуление ключа indentify