CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewLector](@FullName nvarchar(50))
AS
insert [Lectors] ([FullName])
values (@FullName)