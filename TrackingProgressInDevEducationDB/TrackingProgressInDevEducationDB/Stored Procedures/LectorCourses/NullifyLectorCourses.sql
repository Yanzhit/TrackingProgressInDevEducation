CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyLectorCourses]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Lector_Courses]
OUTPUT DELETED.CourseId, DELETED.LectorId