CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyHWGroup]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Homework_Group]
OUTPUT DELETED.Id
DBCC CHECKIDENT ([TrackingProgressInDevEducationDB.Homework_Group], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)