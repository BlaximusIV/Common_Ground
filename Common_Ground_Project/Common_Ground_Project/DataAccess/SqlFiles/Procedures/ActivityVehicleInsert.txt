USE MASTER
GO

CREATE PROCEDURE dbo.ActivityVehicleInsert
(
	@ActivityID INT, 
	@VehicleID INT, 
	@DriverID INT
)
AS 
	SET NOCOUNT ON;

	INSERT INTO Master.dbo.ActivityVehicle
	(
		ActivityID, 
		VehicleID, 
		StaffID
	)
	VALUES
	(
		@ActivityID, 
		@VehicleID, 
		@DriverID
	)

GO	