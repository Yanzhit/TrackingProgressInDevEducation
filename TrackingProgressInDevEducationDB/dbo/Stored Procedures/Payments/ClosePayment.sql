﻿CREATE PROCEDURE [dbo].[ClosePayment]
	@Date date,
	@ID int
AS
	UPDATE [Payments] SET PaymentOn = @Date, [Status] = 1
	WHERE id = @ID
