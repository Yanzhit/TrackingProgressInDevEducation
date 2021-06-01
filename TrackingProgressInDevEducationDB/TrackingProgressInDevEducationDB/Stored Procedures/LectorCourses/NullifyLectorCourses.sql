CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyLectorCourses]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Lector_Courses]
DBCC CHECKIDENT ([Lector_Courses], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)