CREATE PROCEDURE [dbo].[UpdateVisitById](@id int, @VisitStatus bit, @StudentId int, @LectionId int)
AS 
update [dbo].[Visits] set [VisitStatus]=@VisitStatus, [StudentId]=@StudentId, [LectionId]=@LectionId
where id=@id