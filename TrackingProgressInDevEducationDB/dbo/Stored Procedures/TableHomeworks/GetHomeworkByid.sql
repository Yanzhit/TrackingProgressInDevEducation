CREATE PROCEDURE [dbo].[GetHomeworkByid](@ID int)
AS
select * from [Homeworks] 
where id=@ID
