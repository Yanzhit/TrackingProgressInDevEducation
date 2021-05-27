CREATE PROCEDURE [TrackingProgressInDevEducationDB].[UpdateHomeworkByid](@Name nvarchar(50), @ID int)
AS
update [TrackingProgressInDevEducationDB].[Homeworks] set Name=@Name
where id=@ID