CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetHomeWorkProcedureScore]
	@Student int
	--@HomeWorkScore int OUTPUT
AS
	SELECT
	HomeWorkScore = SUM(Score) /  (COUNT(StudentId))
	FROM TrackingProgressInDevEducationDB.HomeworkComplete HWC
	WHERE HWC.StudentId = @Student AND HWC.CreatedOn <= GETDATE()
	GROUP BY HWC.StudentId
