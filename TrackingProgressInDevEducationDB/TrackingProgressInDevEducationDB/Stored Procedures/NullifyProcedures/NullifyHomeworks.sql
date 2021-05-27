CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyHomeworks]
AS
delete from [TrackingProgressInDevEducationDB].[Homeworks]
DBCC CHECKIDENT ([Homeworks], RESEED, 0)  -- Обнуление ключа indentify