CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyLectorGroup]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Lector_Group]
DBCC CHECKIDENT ([Lector_Group], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)