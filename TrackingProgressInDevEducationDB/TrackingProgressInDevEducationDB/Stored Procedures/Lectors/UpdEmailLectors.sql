CREATE PROCEDURE [TrackingProgressInDevEducationDB].[UpdEmailLectors]
	@Id int,
	@Email nvarchar (50),
	@Password nvarchar (50)
AS
	UPDATE Lectors SET [Email] = @Email, [Password] = @Password
	OUTPUT INSERTED.[id], INSERTED.[Email], INSERTED.[Password]
	WHERE [id] = @Id