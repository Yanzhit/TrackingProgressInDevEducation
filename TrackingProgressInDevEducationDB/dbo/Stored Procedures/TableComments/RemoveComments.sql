CREATE PROCEDURE [dbo].[RemoveComments]
AS
delete from [dbo].[Comments]
DBCC CHECKIDENT ([Comments], RESEED, 0)  -- Обнуление ключа indentify