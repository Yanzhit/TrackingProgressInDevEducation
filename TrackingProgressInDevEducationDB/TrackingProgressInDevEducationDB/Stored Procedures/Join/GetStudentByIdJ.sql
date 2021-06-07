CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetStudentByIdJ](@id int)
AS
select S.[id] 
    ,S.[Name]   
    ,[Surname] 
    ,[Rate]    
    ,[Phone] 
    ,[Email] 
    ,[Contract] 
    ,[Birthday] 
    ,[MiddleName] 
    ,[Git] 
	,C.[Name] [City]
	,G.[Name] [Group]
	,Crs.[Name] [Course]
    ,S.[Status] 
	,T.[Name] [Team]
    from [TrackingProgressInDevEducationDB].[Students] S
	JOIN [TrackingProgressInDevEducationDB].[Cities] C ON C.[id] = S.[CityId]
	JOIN [TrackingProgressInDevEducationDB].[Groups] G ON G.[id] = S.[GroupId]
	JOIN [TrackingProgressInDevEducationDB].[Courses] Crs ON Crs.[id] = G.[CourseId]
	LEFT JOIN [TrackingProgressInDevEducationDB].[Team_Student] TS ON TS.[StudentId] = S.[id]
	LEFT JOIN [TrackingProgressInDevEducationDB].[Teams] T ON T.[id] = TS.[TeamId]
where S.[id] = @id AND (GETDATE() BETWEEN T.[From] AND T.[To])  