CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetPaymentsByGroup]
	@Group int
AS
	SELECT PM.id
	,PaymentOn
	,PaymentTo
	,Amount
	,PM.[Status]
	FROM [Payments] PM
	LEFT JOIN [Students] ST ON PM.StudentId = ST.id
	LEFT JOIN [Groups] GP ON ST.GroupId = GP.id
	WHERE GP.id = @Group