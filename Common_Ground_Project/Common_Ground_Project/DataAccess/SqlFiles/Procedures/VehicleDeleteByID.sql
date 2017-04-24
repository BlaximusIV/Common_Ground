USE MASTER
GO

CREATE PROCEDURE dbo.VehicleDeleteByID
(
	@VehicleID INT
)
AS 
	SET NOCOUNT ON;

	UPDATE Master.dbo.Vehicle
	SET IsInUse = 0
	WHERE
		VehicleID = @VehicleID

GO	