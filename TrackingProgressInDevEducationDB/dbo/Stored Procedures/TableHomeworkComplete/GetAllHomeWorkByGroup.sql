CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetAllHomeWorkByGroup]
	@Group int
AS
SELECT HW.id, HW.[Name]
FROM TrackingProgressInDevEducationDB.HomeworkComplete HWC
JOIN TrackingProgressInDevEducationDB.Homeworks HW ON HW.id = HWC.HomeworkId
JOIN TrackingProgressInDevEducationDB.Homework_Group HG ON HG.HomeworkId = HW.id
JOIN TrackingProgressInDevEducationDB.Groups G ON G.id = HG.GroupId
WHERE HG.GroupId = @Group
GROUP BY HW.id, HW.[Name]
