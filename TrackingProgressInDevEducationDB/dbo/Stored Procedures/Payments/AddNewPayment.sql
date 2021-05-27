CREATE PROCEDURE [dbo].[AddNewPayment]
	@Student int,
	@DateTo date,
	@PaymentDate date,
	@Amount decimal,
	@Status bit
AS
	INSERT [Payments] (StudentId, PaymentTo, PaymentOn, Amount, [Status])
	VALUES (@Student, @DateTo, @PaymentDate, @Amount, @Status)
