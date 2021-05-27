CREATE PROCEDURE [dbo].[NullifyTeams]
AS
delete from [dbo].[Teams]
DBCC CHECKIDENT ([Teams], RESEED, 0)  -- Обнуление ключа indentify