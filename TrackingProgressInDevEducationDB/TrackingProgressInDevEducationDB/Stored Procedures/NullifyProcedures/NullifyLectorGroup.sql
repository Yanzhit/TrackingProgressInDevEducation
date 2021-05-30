CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyLectorGroup]
AS
delete from [TrackingProgressInDevEducationDB].[Lector_Group]
DBCC CHECKIDENT ([Lector_Group], RESEED, 0)  -- Обнуление ключа indentify