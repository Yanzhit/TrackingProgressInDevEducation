CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetHomeworkByid](@id int)
AS
select * from [Homeworks] 
where id=@id