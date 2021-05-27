CREATE PROCEDURE [TrackingProgressInDevEducationDB].[AddNewCommentToStudent](@Text nvarchar(50), @TypeId int, @StudentId int, @CreatedBy int)
AS
insert [Comments] ([Text], [TypeId], [StudentId], [CreatedBy])
values (@Text, @TypeId, @StudentId, @CreatedBy)
