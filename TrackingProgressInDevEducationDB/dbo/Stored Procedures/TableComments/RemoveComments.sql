CREATE PROCEDURE [TrackingProgressInDevEducationDB].[RemoveComments]
AS
delete from [TrackingProgressInDevEducationDB].[Comments]
DBCC CHECKIDENT ([Comments], RESEED, 0)  -- Обнуление ключа indentify