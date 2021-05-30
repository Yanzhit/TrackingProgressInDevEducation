CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyLections]
AS
delete from [TrackingProgressInDevEducationDB].[Lections]
DBCC CHECKIDENT ([Lections], RESEED, 0)  -- Обнуление ключа indentify