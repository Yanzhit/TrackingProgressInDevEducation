CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetCommentsByTeam]
	@TeamId int
AS
	SELECT id, [Text] 
	FROM Comments
	WHERE TeamId = @TeamId