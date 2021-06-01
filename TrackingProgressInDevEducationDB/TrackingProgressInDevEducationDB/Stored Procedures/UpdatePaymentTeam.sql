CREATE PROCEDURE [TrackingProgressInDevEducationDB].[UpdatePaymentTeam]
	@id INT,
	@NEWDATE DATE
AS
	UPDATE Payments SET PaymentTo = @NEWDATE
	WHERE id = @id