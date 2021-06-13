CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetCommentToTeam]
	@Text nvarchar (250),
	@TypeId int,
	@CreatedBy int,
	@TeamId int,
	@Estimation int
AS
	INSERT Comments ([Text], TypeId, CreatedBy, TeamId, CommentFor, Estimation)
    OUTPUT INSERTED.id, INSERTED.[Text], INSERTED.TypeId, INSERTED.CreatedBy, INSERTED.TeamId, INSERTED.CommentFor, INSERTED.Estimation 
	VALUES (@Text, @TypeId, @CreatedBy, @TeamId, 1, @Estimation)