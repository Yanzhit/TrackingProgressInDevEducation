CREATE PROCEDURE [TrackingProgressInDevEducationDB].[UpdateHWCompleteByIdHW] (@HomeworkId int, @Status bit )
AS
update [TrackingProgressInDevEducationDB].[HomeworkComplete] set [Status] = @Status
where HomeworkId=@HomeworkId