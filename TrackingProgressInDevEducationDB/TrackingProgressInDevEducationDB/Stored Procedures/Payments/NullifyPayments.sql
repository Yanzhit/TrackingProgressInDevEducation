CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyPayments]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Payments]
OUTPUT DELETED.Id
DBCC CHECKIDENT ([TrackingProgressInDevEducationDB.Payments], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)