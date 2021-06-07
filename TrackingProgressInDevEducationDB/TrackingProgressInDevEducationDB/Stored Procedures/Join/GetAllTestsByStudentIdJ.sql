CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetAllTestsByStudentIdJ]
		@StudentId int
AS
	SELECT TC.[id]
	,TC.[ApproveDate]
	,TC.[Score]
	,TC.[Status]
	,T.[Name]
	,T.[Description]
	FROM TestComplete TC
	JOIN Tests T ON T.[id] = TC.TestId
	WHERE TC.[StudentId] = @StudentId
