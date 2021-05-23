CREATE PROCEDURE [dbo].[UpdatePaymentSetDateAndStatus]
	@ID INT,
	@NEWDATE DATE
AS
	IF @NEWDATE = null SET @NEWDATE = GetDate()
	UPDATE Payments SET PaymentTo = @NEWDATE, [Status] = 1 
	WHERE id = @ID
