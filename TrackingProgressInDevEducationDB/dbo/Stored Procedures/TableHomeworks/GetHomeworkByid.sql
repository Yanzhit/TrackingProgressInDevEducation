CREATE PROCEDURE [dbo].[GetHomeworkByid](@ID int)
AS
select * from [Homework] 
where id=@ID
