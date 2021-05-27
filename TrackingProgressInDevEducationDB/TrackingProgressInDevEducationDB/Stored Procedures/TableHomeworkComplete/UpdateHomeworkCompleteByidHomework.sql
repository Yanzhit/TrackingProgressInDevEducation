CREATE PROCEDURE [TrackingProgressInDevEducationDB].[UpdateHomeworkCompleteByidHomework] (@HomeworkId int, @Status bit )
AS
update [TrackingProgressInDevEducationDB].[HomeworkComplete] set [Status] = @Status
where HomeworkId=@HomeworkId