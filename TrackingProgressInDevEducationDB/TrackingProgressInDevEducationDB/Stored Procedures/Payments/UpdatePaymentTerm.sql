CREATE PROCEDURE [TrackingProgressInDevEducationDB].[UpdatePaymentTerm]
	@id INT,
	@NEWDATE DATE
AS
	UPDATE Payments SET PaymentTo = @NEWDATE
	WHERE id = @id