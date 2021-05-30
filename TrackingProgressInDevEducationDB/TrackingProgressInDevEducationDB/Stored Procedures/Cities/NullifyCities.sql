CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyCities]
AS
delete from [TrackingProgressInDevEducationDB].[Cities]
DBCC CHECKIDENT ([Cities], RESEED, 0)  -- Обнуление ключа indentify