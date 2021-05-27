CREATE PROCEDURE [dbo].[GetVisitById](@id int)
AS 
select * from [Visits]
where id=@id