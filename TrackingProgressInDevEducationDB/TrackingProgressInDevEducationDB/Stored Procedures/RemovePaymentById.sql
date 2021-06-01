CREATE PROCEDURE [TrackingProgressInDevEducationDB].[RemovePaymentById]
	@id INT
AS
	DELETE Payments 
	WHERE id = @id
