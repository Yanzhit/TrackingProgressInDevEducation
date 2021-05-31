CREATE PROCEDURE [TrackingProgressInDevEducationDB].[UpdateHWCompleteByIdStudents](@Studentid int, @Status bit)
AS
update [TrackingProgressInDevEducationDB].[HomeworkComplete] set [Status] = @Status
where StudentId=@Studentid