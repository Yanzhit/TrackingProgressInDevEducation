CREATE PROCEDURE [TrackingProgressInDevEducationDB].[UpdateVisitById](@ID int, @VisitStatus bit, @StudentId int, @LectionId int)
AS 
update [TrackingProgressInDevEducationDB].[Visits] set [VisitStatus]=@VisitStatus, [StudentId]=@StudentId, [LectionId]=@LectionId
where id=@ID