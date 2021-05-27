CREATE PROCEDURE [dbo].[NullifyHomework_Group]
AS
delete from [dbo].[Homework_Group]
DBCC CHECKIDENT ([Homework_Group], RESEED, 0)  -- Обнуление ключа indentify