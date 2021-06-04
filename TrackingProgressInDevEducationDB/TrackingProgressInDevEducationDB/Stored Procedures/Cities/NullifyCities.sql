CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyCities]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Cities]
OUTPUT DELETED.id
DBCC CHECKIDENT ([TrackingProgressInDevEducationDB.Cities], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)