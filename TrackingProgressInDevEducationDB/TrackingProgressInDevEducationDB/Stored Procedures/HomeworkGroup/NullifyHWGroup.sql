CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyHWGroup]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Homework_Group]
OUTPUT DELETED.GroupId, DELETED.HomeworkId