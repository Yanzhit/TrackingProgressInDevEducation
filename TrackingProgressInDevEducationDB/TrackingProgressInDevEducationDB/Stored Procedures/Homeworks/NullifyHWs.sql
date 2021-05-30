CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyHWs]
AS
delete from [TrackingProgressInDevEducationDB].[Homeworks]
DBCC CHECKIDENT ([Homeworks], RESEED, 0)  -- Обнуление ключа indentify