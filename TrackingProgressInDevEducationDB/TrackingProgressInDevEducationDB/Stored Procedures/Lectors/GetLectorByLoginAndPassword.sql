CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetLectorByLoginAndPassword]
	@Login nvarchar (50),
	@Password nvarchar (50)
AS
	SELECT [id]
    ,[FullName]
    ,[Email] 
    ,[Password]
	,[IsActivated]

	FROM [TrackingProgressInDevEducationDB].[Lectors]
	WHERE [Email] = @Login AND [Password] = @Password
