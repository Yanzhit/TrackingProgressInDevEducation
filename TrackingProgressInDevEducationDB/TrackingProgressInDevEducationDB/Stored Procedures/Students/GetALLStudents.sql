CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetALLStudents] @Status BIT
AS

select [id]      
    ,[Name]    
    ,[Surname] 
    ,[Rate]    
    ,[GroupId] 
    ,[Phone] 
    ,[Email] 
   ,[Contract] 
    ,[Birthday] 
    ,[MiddleName] 
    ,[Git] 
    ,[CityId] 
    ,[Status]
    from [Students]
    WHERE [Status] = @Status