USE MASTER
GO

CREATE PROCEDURE dbo.IndividualWaiverReset
AS 
	SET NOCOUNT ON;

	UPDATE Master.dbo.Individual 
	SET
		IsWaiverSigned = 0

GO	