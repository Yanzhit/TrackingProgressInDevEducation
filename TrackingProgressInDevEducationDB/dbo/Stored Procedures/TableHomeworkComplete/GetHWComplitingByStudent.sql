CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetHWComplitingByStudent]
	@StudentId int
AS
	SELECT HWC.id
	,HWC.[Status]
	,HW.[Name]
	,HW.Deskription
	FROM HomeworkComplete HWC
	JOIN Homeworks HW ON HW.id = HWC.HomeworkId
	WHERE HWC.StudentId = @StudentId
