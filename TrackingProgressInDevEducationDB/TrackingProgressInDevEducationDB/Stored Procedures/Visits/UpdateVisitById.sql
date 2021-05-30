CREATE PROCEDURE [TrackingProgressInDevEducationDB].[UpdateVisitById](@id int, @VisitStatus bit, @StudentId int, @LectionId int)
AS 
update [TrackingProgressInDevEducationDB].[Visits] set [VisitStatus]=@VisitStatus, [StudentId]=@StudentId, [LectionId]=@LectionId
where id=@id