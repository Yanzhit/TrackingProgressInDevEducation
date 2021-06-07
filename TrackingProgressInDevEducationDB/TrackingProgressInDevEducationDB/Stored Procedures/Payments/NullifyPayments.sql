CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyPayments]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Payments]
OUTPUT DELETED.[id]
DBCC CHECKIDENT ([TrackingProgressInDevEducationDB.Payments], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)