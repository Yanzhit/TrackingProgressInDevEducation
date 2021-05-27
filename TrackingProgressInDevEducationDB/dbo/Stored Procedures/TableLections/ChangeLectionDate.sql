CREATE PROCEDURE [TrackingProgressInDevEducationDB].[ChangeLectionDate]
	@LectionId int,
	@Date date
AS
	UPDATE Lections
	SET StartedOn = @Date
	WHERE id = @LectionId
