CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewNewPayment]
(
	 @Student INT
	,@DateTo DATE
	,@PaymentDate DATE
	,@Amount DECIMAL(10)
	,@Status BIT
)
AS
	INSERT [Payments]
	(
		 [StudentId]
		,[PaymentTo]
		,[PaymentOn]
		,[Amount]
		,[Status]
	)
	VALUES
	(
		 @Student
		,@DateTo
		,@PaymentDate
		,@Amount
		,@Status
	)
--ZLoo (Все ок)