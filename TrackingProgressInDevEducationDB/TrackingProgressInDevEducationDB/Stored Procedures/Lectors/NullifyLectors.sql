CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyLectors]
AS
delete from [TrackingProgressInDevEducationDB].[Lectors]
DBCC CHECKIDENT ([Lectors], RESEED, 0)  -- Обнуление ключа indentify