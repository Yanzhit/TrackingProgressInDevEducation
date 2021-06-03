CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewStudent]
(
	 @Name NVARCHAR(50)
	,@Surname NVARCHAR(50)
	,@Rate DECIMAL(6,2)
	,@GroupId INT
	,@Phone NVARCHAR(50)
	,@Email NVARCHAR(50)
	,@Contract NVARCHAR(50)
	,@Birthday DATE
	,@MiddleName NVARCHAR(50)
	,@Git NVARCHAR(50)
	,@CityId INT
	,@Status BIT
)
AS
	INSERT [Students] 
	(
		 [Name]
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
	)
	OUTPUT INSERTED.Id
	VALUES
	(
		 @Name
		,@Surname
		,@Rate
		,@GroupId
		,@Phone
		,@Email
		,@Contract
		,@Birthday
		,@MiddleName
		,@Git
		,@CityId
		,@Status
	)
--ZLoo (Все ок)