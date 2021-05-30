CREATE PROCEDURE [TrackingProgressInDevEducationDB].[UpdateClosePayment]
	@Date date,
	@id int
AS
	UPDATE [Payments] SET PaymentOn = @Date, [Status] = 1
	WHERE id = @id
