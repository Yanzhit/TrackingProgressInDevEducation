CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyTeams]
AS
delete from [TrackingProgressInDevEducationDB].[Teams]
DBCC CHECKIDENT ([Teams], RESEED, 0)  -- Обнуление ключа indentify