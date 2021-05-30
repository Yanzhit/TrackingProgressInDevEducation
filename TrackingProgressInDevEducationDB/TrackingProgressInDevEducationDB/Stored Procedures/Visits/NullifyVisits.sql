CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyVisits]
AS
delete from [TrackingProgressInDevEducationDB].[Visits]
DBCC CHECKIDENT ([Visits], RESEED, 0)  -- Обнуление ключа indentify