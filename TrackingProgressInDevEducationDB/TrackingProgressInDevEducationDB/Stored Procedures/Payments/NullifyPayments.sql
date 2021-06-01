CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyPayments]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Payments]
DBCC CHECKIDENT ([Payments], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)