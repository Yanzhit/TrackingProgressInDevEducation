CREATE PROCEDURE [dbo].[NullifyLections]
AS
delete from [dbo].[Lections]
DBCC CHECKIDENT ([Lections], RESEED, 0)  -- Обнуление ключа indentify