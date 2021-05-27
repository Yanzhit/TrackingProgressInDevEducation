CREATE PROCEDURE [dbo].[NullifyTeam_Student]
AS
delete from [dbo].[Team_Student]
DBCC CHECKIDENT ([Team_Student], RESEED, 0)  -- Обнуление ключа indentify