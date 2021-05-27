CREATE PROCEDURE [dbo].[NullifyHomeworks]
AS
delete from [dbo].[Homeworks]
DBCC CHECKIDENT ([Homeworks], RESEED, 0)  -- Обнуление ключа indentify