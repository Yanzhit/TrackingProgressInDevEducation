CREATE PROCEDURE [dbo].[NullifyComments]
AS
delete from [dbo].[Comments]
DBCC CHECKIDENT ([Comments], RESEED, 0)  -- Обнуление ключа indentify