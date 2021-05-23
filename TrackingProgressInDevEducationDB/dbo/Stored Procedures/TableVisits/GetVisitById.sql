CREATE PROCEDURE [dbo].[GetVisitById](@ID int)
AS 
select * from [Visits]
where id=@ID