CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetAllCommentsByTeam]
	@TeamId int
AS
	SELECT id, [Text] 
	FROM Comments
	WHERE TeamId = @TeamId
