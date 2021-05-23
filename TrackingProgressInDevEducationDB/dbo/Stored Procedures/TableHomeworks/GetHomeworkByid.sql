CREATE PROCEDURE [dbo].[GetHomeworkByid](@id int)
AS
select * from [Homework] 
where id=@ID
