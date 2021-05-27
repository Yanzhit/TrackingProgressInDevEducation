CREATE PROCEDURE [dbo].[NullifyPayments]
AS
delete from [dbo].[Payments]
DBCC CHECKIDENT ([Payments], RESEED, 0)  -- Обнуление ключа indentify