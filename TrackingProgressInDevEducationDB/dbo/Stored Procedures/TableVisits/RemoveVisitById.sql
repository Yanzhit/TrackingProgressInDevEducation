CREATE PROCEDURE [dbo].[RemoveVisitById](@id int)
AS 
delete from [dbo].[Visits]
where id=@id