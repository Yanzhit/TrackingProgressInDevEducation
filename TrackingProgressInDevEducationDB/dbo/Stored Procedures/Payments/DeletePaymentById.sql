CREATE PROCEDURE [dbo].[DeletePaymentById]
	@ID INT
AS
	DELETE Payments 
	WHERE id = @ID
