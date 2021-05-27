CREATE PROCEDURE [TrackingProgressInDevEducationDB].[RemoveLectors]
AS
delete from [TrackingProgressInDevEducationDB].[Lectors]
DBCC CHECKIDENT ([Lectors], RESEED, 0)  -- Обнуление ключа indentify