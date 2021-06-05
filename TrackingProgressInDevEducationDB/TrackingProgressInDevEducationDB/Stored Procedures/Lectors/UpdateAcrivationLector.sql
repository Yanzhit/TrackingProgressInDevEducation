CREATE PROCEDURE [TrackingProgressInDevEducationDB].[UpdateAcrivationLector]
(
	 @Id INT
	,@isActivated BIT
)	
AS
	UPDATE [TrackingProgressInDevEducationDB].[Lectors]

	SET [IsActivated] = @isActivated

	OUTPUT
	
		  INSERTED.[IsActivated]
		 ,INSERTED.[id]
	
	WHERE [id] = @Id