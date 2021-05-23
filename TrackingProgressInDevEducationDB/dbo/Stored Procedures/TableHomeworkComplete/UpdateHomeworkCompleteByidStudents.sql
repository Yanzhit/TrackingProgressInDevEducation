CREATE PROCEDURE [dbo].[UpdateHomeworkCompleteByidStudents](@Studentid int, @Status bit)

AS
update [dbo].[HomeworkComplete] set Status = @Status
where StudentId=@Studentid
