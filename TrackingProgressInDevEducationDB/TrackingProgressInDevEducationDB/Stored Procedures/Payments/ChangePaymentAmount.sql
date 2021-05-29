CREATE PROCEDURE [TrackingProgressInDevEducationDB].[ChangePaymentAmount]
	@Amount decimal,
	@id int
AS
	UPDATE [Payments] SET Amount = @Amount 
	WHERE id = @id
