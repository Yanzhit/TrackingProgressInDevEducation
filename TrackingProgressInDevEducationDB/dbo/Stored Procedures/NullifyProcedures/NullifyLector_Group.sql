CREATE PROCEDURE [dbo].[NullifyLector_Group]
AS
delete from [dbo].[Lector_Group]
DBCC CHECKIDENT ([Lector_Group], RESEED, 0)  -- Обнуление ключа indentify