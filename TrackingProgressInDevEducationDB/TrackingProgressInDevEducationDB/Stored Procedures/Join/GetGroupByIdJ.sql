CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetGroupByIdJ](@id int)
AS 
select G.[id]      
      ,G.[Name] [NameG]   
      ,C.[Name] [NameC]
      ,G.[StartDate] 
      ,G.[EndDate] 
      ,C.[Description]
      FROM [TrackingProgressInDevEducationDB].Groups G
      JOIN [TrackingProgressInDevEducationDB].Courses C ON G.CourseId = C.[id]
where G.[id]=@id