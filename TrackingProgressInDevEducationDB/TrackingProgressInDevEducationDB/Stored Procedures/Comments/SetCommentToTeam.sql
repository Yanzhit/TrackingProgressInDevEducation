CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetCommentToTeam]
	@TeamId int,
	@Text nvarchar (250),
	@CommentType int,
	@Lector int,
	@Estimation decimal
AS
	INSERT Comments ([Text], TeamId, TypeId, CreatedBy, CommentFor, Estimation)
	OUTPUT INSERTED.Id
	VALUES (@Text, @TeamId, @CommentType, @Lector, 1, @Estimation)