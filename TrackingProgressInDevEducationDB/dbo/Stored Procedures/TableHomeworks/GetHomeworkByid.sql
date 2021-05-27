CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetHomeworkByid](@ID int)
AS
select * from [Homework] 
where id=@ID
