CREATE PROCEDURE [TrackingProgressInDevEducationDB].[NullifyCourses]
AS
delete from [TrackingProgressInDevEducationDB].[Courses]
DBCC CHECKIDENT ([Courses], RESEED, 0)  -- Обнуление ключа indentify