USE MASTER
GO

CREATE PROCEDURE dbo.ActivityVehicleDeleteByID
(
	@ActivityID INT, 
	@VehicleID INT
)
AS 
	SET NOCOUNT ON;

	DELETE 
	FROM Master.dbo.ActivityVehicle
	WHERE
		ActivityID = @ActivityID
		AND VehicleID = @VehicleID

GO	