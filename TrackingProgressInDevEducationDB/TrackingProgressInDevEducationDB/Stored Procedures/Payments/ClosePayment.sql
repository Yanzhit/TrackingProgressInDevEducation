CREATE PROCEDURE [TrackingProgressInDevEducationDB].[ClosePayment]
	@Date date,
	@id int
AS
	UPDATE [Payments] SET PaymentOn = @Date, [Status] = 1
	WHERE id = @id
