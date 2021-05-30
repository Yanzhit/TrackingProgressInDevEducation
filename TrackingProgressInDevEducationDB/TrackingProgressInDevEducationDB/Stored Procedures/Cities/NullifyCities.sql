CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyCities]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Cities]
DBCC CHECKIDENT ([Cities], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)