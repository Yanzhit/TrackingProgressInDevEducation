CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetAllLector] 
AS
select [id], [FullName], [Password], [Email] from [Lectors]