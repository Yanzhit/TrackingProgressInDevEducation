CREATE PROCEDURE [TrackingProgressInDevEducationDB].[UpdLoginLectors]
	@Id int,
	@Login nvarchar (50),
	@Password nvarchar (50)
AS
	UPDATE Lectors SET [Login] = @Login
	OUTPUT INSERTED.[id], INSERTED.[Login], INSERTED.[Password]
	WHERE [id] = @Id AND [Password] = @Password