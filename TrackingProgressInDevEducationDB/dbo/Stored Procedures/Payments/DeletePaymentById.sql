CREATE PROCEDURE [TrackingProgressInDevEducationDB].[DeletePaymentById]
	@ID INT
AS
	DELETE Payments 
	WHERE id = @ID
