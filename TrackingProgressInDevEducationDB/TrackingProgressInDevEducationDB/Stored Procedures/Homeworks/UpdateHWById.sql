CREATE PROCEDURE [TrackingProgressInDevEducationDB].[UpdateHWById](@Name nvarchar(50), @id int)
AS
update [TrackingProgressInDevEducationDB].[Homeworks] set Name=@Name
where id=@id