CREATE PROCEDURE [dbo].[NullifyCourses]
AS
delete from [dbo].[Courses]
DBCC CHECKIDENT ([Courses], RESEED, 0)  -- Обнуление ключа indentify