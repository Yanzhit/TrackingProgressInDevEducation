CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetAllLectionsByGroup]
	@GroupId int
AS
	SELECT id, StartedOn, LectorId, GroupId
	FROM Lections
	WHERE GroupId = @GroupId