CREATE PROCEDURE [dbo].[NullifyGroups]
AS
delete from [dbo].[Groups]
DBCC CHECKIDENT ([Groups], RESEED, 0)  -- Обнуление ключа indentify