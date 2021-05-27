CREATE PROCEDURE [dbo].[NullifyStudents]
AS
delete from [dbo].[Students]
DBCC CHECKIDENT ([Students], RESEED, 0)  -- Обнуление ключа indentify