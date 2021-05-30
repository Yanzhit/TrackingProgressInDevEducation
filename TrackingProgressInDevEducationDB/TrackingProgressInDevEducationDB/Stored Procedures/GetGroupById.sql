CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetGroupById](@id int)
AS 
select * from [Groups]
where id=@id