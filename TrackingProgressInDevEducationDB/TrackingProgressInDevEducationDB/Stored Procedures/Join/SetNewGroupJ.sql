CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewGroupJ]
(
   @GroupId INT = null
   ,@LectorId INT
   ,@Name NVARCHAR(50)
  ,@CourseId INT
  ,@StartDate NVARCHAR(50)
  ,@EndDate NVARCHAR(50)
)
AS 
BEGIN
  IF @StartDate = null SET @StartDate = GetDate()
  INSERT [Groups]
  (
     [Name]
    ,[CourseId]
    ,[StartDate]
    ,[EndDate]
  )
	OUTPUT INSERTED.id, INSERTED.[Name], INSERTED.CourseId, INSERTED.StartDate, INSERTED.EndDate
  VALUES
  (
     @Name
    ,@CourseId
    ,@StartDate
    ,@EndDate
  );
  SET @GroupId = SCOPE_IDENTITY();
  INSERT Lector_Group (GroupId, LectorId)
  Values (@GroupId, @LectorId)
END