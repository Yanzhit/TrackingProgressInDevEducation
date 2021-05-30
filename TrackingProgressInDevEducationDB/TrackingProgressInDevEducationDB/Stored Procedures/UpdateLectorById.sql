CREATE PROCEDURE [TrackingProgressInDevEducationDB].[UpdateLectorById](@ID int, @FullName nvarchar(50))
AS
update [TrackingProgressInDevEducationDB].[Lectors] set FullName=@FullName
where id=@ID