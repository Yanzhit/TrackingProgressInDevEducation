CREATE PROCEDURE [dbo].[UpdateHomeworkCompleteByidHomework] (@HomeworkId int, @Status bit )
AS
update [dbo].[HomeworkComplete] set [Status] = @Status
where HomeworkId=@HomeworkId
