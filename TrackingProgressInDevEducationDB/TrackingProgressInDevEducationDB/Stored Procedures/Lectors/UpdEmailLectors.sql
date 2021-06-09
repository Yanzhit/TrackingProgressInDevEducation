CREATE PROCEDURE [TrackingProgressInDevEducationDB].[UpdEmailLectors]
	@Id int,
	@Email nvarchar (50),
	@Password nvarchar (50)
AS
	UPDATE Lectors SET [Email] = @Email
	OUTPUT INSERTED.[id], INSERTED.[Email], INSERTED.[Password]
	WHERE [id] = @Id AND [Password] = @Password