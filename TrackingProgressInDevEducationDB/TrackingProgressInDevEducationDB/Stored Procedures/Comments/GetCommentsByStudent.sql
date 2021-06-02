CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetCommentsByStudent] 
@StudentId int,
@CommentType int,
@CommentFor int
AS
	SELECT id, [Text], Estimation
	FROM [TrackingProgressInDevEducationDB].Comments
	WHERE StudentId = @StudentId AND TypeId = @CommentType AND CommentFor = @CommentFor