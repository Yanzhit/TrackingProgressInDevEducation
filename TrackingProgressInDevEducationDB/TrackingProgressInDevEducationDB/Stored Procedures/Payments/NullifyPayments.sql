CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyPayments]
AS
delete from [TrackingProgressInDevEducationDB].[Payments]
DBCC CHECKIDENT ([Payments], RESEED, 0)  -- Обнуление ключа indentify