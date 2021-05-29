CREATE PROCEDURE [TrackingProgressInDevEducationDB].[DeletePaymentById]
	@id INT
AS
	DELETE Payments 
	WHERE id = @id
