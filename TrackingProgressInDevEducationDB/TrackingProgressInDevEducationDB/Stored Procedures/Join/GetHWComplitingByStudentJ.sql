CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetHWComplitingByStudentJ]
	@StudentId int
AS
	SELECT HWC.[id]
	,HWC.[ApproveDate]
	,HWC.[Score]
	,HWC.[Status]
	,HW.[Name]
	,HW.[Deskription]
	FROM HomeworkComplete HWC
	JOIN Homeworks HW ON HW.[id] = HWC.[HomeworkId]
	WHERE HWC.[StudentId] = @StudentId