CREATE PROCEDURE [TrackingProgressInDevEducationDB].[UpdatePaymentTerm]
	@ID INT,
	@NEWDATE DATE
AS
	UPDATE Payments SET PaymentTo = @NEWDATE
	WHERE id = @ID
