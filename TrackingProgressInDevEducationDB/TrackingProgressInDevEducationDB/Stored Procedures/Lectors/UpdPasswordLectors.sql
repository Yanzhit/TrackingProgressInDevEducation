CREATE PROCEDURE [TrackingProgressInDevEducationDB].[UpdPasswordLectors]
	@Id int,
	@Password nvarchar (50)
AS
	UPDATE Lectors SET [Password] = @Password
	OUTPUT INSERTED.[id], INSERTED.[Password]
	WHERE [id] = @Id AND [Password] = @Password