CREATE PROCEDURE [dbo].[RemoveStudents]
AS
delete from [dbo].[Students]
DBCC CHECKIDENT ([Students], RESEED, 0)  -- Обнуление ключа indentify