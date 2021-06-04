CREATE PROCEDURE [TrackingProgressInDevEducationDB].[UpdNewEmailAndPasswordLectors]
	@Id int,
	@Email nvarchar (50),
	@Password nvarchar (50)
AS
	UPDATE Lectors SET Email = @Email, [Password] = @Password
	OUTPUT DELETED.id
	WHERE id = @Id