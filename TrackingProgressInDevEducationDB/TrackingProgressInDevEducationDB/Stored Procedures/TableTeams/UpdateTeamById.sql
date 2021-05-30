CREATE PROCEDURE [TrackingProgressInDevEducationDB].[UpdateTeamById](@id int,@Name nvarchar(50))
AS 
update [TrackingProgressInDevEducationDB].[Teams] set [Name]=@Name
where [id]=@id