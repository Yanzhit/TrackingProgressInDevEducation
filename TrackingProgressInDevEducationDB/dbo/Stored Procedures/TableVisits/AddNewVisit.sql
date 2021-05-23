CREATE PROCEDURE [dbo].[AddNewVisit](@VisitStatus bit, @StudentId int, @LectionId int)
AS 
insert [Visits] ([VisitStatus], [StudentId], [LectionId])
values (@VisitStatus, @StudentId, @LectionId)
