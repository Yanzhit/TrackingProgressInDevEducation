CREATE PROCEDURE [dbo].[ChangePaymentAmount]
	@Amount decimal,
	@ID int
AS
	UPDATE [Payments] SET Amount = @Amount 
	WHERE id = @ID
