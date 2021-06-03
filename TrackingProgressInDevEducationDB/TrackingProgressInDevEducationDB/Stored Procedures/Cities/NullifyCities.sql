CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyCities]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Cities]
OUTPUT DELETED.Id
DBCC CHECKIDENT ([TrackingProgressInDevEducationDB.Cities], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)