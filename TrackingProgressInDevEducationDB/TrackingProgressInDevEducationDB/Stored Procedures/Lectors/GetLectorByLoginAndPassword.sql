CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetLectorByLoginAndPassword]
	@Login nvarchar (50),
	@Password nvarchar (50)
AS
	SELECT [id]
	,[Login]
    ,[FullName]
    ,[Email] 
    ,[Password]
	,[IsActivated]

	FROM [TrackingProgressInDevEducationDB].[Lectors]
	WHERE [Login] = @Login AND [Password] = @Password
