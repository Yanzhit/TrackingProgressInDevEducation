CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyCourses]
AS
DELETE FROM [TrackingProgressInDevEducationDB].[Courses]
OUTPUT DELETED.id
DBCC CHECKIDENT ([TrackingProgressInDevEducationDB.Courses], RESEED, 0)  -- Обнуление ключа indentify
--ZLoo (Все ок)