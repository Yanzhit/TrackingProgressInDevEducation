CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyHomeworkGroup]
AS
delete from [TrackingProgressInDevEducationDB].[Homework_Group]
DBCC CHECKIDENT ([Homework_Group], RESEED, 0)  -- Обнуление ключа indentify