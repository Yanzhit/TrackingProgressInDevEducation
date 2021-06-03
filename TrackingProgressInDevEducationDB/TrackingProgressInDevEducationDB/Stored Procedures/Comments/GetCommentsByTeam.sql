CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetCommentsByTeam]
@TeamId int,
@CommentType int,
@CommentFor int --Team this parameter is unnecesary
AS
IF @CommentFor = NULL SET @CommentFor = 1
	SELECT id, [Text], Estimation
	FROM [TrackingProgressInDevEducationDB].Comments
	WHERE TeamId = @TeamId AND TypeId = @CommentType AND CommentFor = @CommentFor