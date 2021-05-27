CREATE PROCEDURE [dbo].[GetHomeworkByid](@id int)
AS
select * from [Homeworks] 
where id=@id
