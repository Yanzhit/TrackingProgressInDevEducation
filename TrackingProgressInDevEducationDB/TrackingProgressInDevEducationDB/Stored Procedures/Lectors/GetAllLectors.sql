CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetAllLectors] 
AS
select id, FullName, [Email], [Password] from [Lectors]