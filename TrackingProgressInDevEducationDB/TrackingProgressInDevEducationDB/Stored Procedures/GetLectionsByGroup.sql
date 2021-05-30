CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetLectionsByGroup]
	@GroupId int
AS
	SELECT id, StartedOn, LectorId, GroupId
	FROM Lections
	WHERE GroupId = @GroupId