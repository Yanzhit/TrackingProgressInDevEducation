CREATE PROCEDURE [dbo].[RemoveLectors]
AS
delete from [dbo].[Lectors]
DBCC CHECKIDENT ([Lectors], RESEED, 0)  -- Обнуление ключа indentify