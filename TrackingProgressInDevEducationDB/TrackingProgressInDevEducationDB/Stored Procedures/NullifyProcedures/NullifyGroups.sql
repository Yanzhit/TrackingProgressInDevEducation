CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyGroups]
AS
delete from [TrackingProgressInDevEducationDB].[Groups]
DBCC CHECKIDENT ([Groups], RESEED, 0)  -- Обнуление ключа indentify