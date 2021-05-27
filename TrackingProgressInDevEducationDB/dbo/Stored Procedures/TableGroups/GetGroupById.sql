CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetGroupById](@ID int)
AS 
select * from [Groups]
where id=@ID