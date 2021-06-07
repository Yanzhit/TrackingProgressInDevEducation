CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewCommentToStudent](@Text nvarchar(50), @TypeId int, @StudentId int, @CreatedBy int, @Estimation decimal)
AS
INSERT [Comments] ([Text], [TypeId], [StudentId], [CreatedBy],CommentFor, Estimation)
OUTPUT INSERTED.id, INSERTED.[Text], INSERTED.TypeId, INSERTED.StudentId, INSERTED.CreatedBy, INSERTED.CommentFor, INSERTED.Estimation 
VALUES (@Text, @TypeId, @StudentId, @CreatedBy, 2, @Estimation)