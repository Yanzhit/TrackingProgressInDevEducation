CREATE PROCEDURE [dbo].[NullifyHomeworkComplete]
AS
delete from [dbo].[HomeworkComplete]
DBCC CHECKIDENT ([HomeworkComplete], RESEED, 0)  -- Обнуление ключа indentify