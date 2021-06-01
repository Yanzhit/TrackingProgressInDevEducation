CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyCourses]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Courses]
DBCC CHECKIDENT ([Courses], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)