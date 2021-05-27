CREATE PROCEDURE [TrackingProgressInDevEducationDB].[AddNewLector](@FullName nvarchar(50))
AS
insert [Lectors] ([FullName])
values (@FullName)