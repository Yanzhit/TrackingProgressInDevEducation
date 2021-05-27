CREATE PROCEDURE [TrackingProgressInDevEducationDB].[AddEmailAndPassword]
	@Id int,
	@Email nvarchar (50),
	@Password nvarchar (50)
AS
	UPDATE Lectors SET Email = @Email, [Password] = @Password
	WHERE id = @Id
