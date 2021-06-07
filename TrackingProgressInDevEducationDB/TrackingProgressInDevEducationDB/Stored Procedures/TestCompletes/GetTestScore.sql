CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetTestScore]
@Student int
	--@TestScore int OUTPUT
AS
	SELECT
	TestScore = SUM(Score) /  (COUNT(StudentId))
	FROM TrackingProgressInDevEducationDB.TestComplete TC
	WHERE TC.[StudentId] = @Student
	GROUP BY TC.[StudentId]
