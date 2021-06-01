CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetLectionToGroup]
	@Group int,
	@Lector int,
	@StartedOn date
AS
	INSERT Lections
	VALUES(@Group, @Lector, @StartedOn)