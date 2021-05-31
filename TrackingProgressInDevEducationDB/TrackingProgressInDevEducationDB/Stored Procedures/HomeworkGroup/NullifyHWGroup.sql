CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyHWGroup]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Homework_Group]
DBCC CHECKIDENT ([Homework_Group], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)