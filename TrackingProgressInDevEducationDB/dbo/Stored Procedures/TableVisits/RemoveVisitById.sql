CREATE PROCEDURE [dbo].[RemoveVisitById](@ID int)
AS 
delete from [dbo].[Visits]
where id=@ID