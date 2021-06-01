CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyTests]
	@param1 int = 0,
	@param2 int
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Tests]
DBCC CHECKIDENT ([Tests], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)