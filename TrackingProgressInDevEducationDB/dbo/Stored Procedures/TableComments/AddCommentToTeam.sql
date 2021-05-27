CREATE PROCEDURE [TrackingProgressInDevEducationDB].[AddCommentToTeam]
	@TeamId int,
	@Text nvarchar (250),
	@CommentType int,
	@Lector int
AS
	INSERT Comments ([Text], TeamId, TypeId, CreatedBy)
	VALUES (@Text, @TeamId, @CommentType, @Lector)
