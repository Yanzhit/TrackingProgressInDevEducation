CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewCommentToStudent](@Text nvarchar(50), @TypeId int, @StudentId int, @CreatedBy int, @Estimation decimal)
AS
insert [Comments] ([Text], [TypeId], [StudentId], [CreatedBy],CommentFor, Estimation)
values (@Text, @TypeId, @StudentId, @CreatedBy, 2, @Estimation)