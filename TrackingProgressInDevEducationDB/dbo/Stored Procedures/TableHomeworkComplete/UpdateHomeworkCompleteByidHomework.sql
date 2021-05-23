CREATE PROCEDURE [dbo].[UpdateHomeworkCompleteByidHomework](@Status bit, @Homeworkid int)
AS
update [dbo].[HomeworkComplete] set Status = @Status
where Homeworkid=@Homeworkid
