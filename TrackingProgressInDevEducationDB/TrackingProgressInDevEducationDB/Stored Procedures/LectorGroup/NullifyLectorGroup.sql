CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyLectorGroup]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Lector_Group]
OUTPUT DELETED.[GroupId], DELETED.[LectorId]