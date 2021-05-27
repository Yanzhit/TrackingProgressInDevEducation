CREATE PROCEDURE [dbo].[NullifyVisits]
AS
delete from [dbo].[Visits]
DBCC CHECKIDENT ([Visits], RESEED, 0)  -- Обнуление ключа indentify