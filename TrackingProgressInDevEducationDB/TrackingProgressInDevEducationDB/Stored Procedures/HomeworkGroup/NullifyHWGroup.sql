CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyHWGroup]
AS
delete from [TrackingProgressInDevEducationDB].[Homework_Group]
DBCC CHECKIDENT ([Homework_Group], RESEED, 0)  -- Обнуление ключа indentify