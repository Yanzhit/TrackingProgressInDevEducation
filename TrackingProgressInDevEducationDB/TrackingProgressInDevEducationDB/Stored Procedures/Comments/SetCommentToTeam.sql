CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetCommentToTeam]
	@TeamId int,
	@Text nvarchar (250),
	@CommentType int,
	@Lector int,
	@Estimation decimal
AS
	INSERT Comments ([Text], TeamId, TypeId, CreatedBy, CommentFor, Estimation)
	OUTPUT INSERTED.id, INSERTED.TeamId, INSERTED.TypeId, INSERTED.CreatedBy, INSERTED.CommentFor, INSERTED.Estimation
	VALUES (@Text, @TeamId, @CommentType, @Lector, 1, @Estimation)