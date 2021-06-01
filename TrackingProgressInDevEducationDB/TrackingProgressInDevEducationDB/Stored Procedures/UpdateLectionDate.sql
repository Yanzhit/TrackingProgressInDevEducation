CREATE PROCEDURE [TrackingProgressInDevEducationDB].[UpdateLectionDate]
	@LectionId int,
	@Date date
AS
	UPDATE Lections
	SET StartedOn = @Date
	WHERE id = @LectionId