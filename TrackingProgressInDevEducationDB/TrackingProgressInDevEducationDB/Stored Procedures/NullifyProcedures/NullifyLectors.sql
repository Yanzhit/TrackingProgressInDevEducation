CREATE PROCEDURE [dbo].[NullifyLectors]
AS
delete from [dbo].[Lectors]
DBCC CHECKIDENT ([Lectors], RESEED, 0)  -- Обнуление ключа indentify