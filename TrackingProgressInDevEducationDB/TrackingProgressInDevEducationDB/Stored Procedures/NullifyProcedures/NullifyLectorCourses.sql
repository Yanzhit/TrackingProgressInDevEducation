CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyLectorCourses]
AS
delete from [TrackingProgressInDevEducationDB].[Lector_Courses]
DBCC CHECKIDENT ([Lector_Courses], RESEED, 0)  -- Обнуление ключа indentify