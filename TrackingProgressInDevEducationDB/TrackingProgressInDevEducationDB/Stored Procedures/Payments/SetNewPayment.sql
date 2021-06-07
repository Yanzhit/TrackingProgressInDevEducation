CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewNewPayment]
(
	 @Student INT
	,@DateTo NVARCHAR(50)
	,@PaymentDate NVARCHAR(50)
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
	OUTPUT INSERTED.[id]
	VALUES
	(
		 @Student
		,@DateTo
		,@PaymentDate
		,@Amount
		,@Status
	)
--ZLoo (Все ок)