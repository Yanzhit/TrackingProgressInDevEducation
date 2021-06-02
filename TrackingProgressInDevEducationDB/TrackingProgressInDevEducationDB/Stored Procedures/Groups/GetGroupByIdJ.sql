CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetGroupByIdJ](@id int)
AS 
select G.[id]      
      ,G.[Name]    
      ,C.[Name]
      ,G.[StartDate] 
      ,G.[EndDate] 
      FROM [TrackingProgressInDevEducationDB].Groups G
      JOIN [TrackingProgressInDevEducationDB].Courses C ON G.CourseId = C.id
where G.id=@id