CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyTStudent]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Team_Student]
OUTPUT DELETED.StudentId, DELETED.TeamId