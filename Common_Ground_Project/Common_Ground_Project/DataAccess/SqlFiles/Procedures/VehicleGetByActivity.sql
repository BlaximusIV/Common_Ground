USE MASTER
GO

CREATE PROCEDURE dbo.VehicleGetByActivity
(
	@ActivityID INT
)
AS 
	SET NOCOUNT ON;

	SELECT
		v.VehicleID, 
		v.Name, 
		v.Description, 
		v.VIN
	FROM
		Master.dbo.Vehicle v
		JOIN Master.dbo.ActivityVehicle av ON av.VehicleID = v.VehicleID
	WHERE
		ActivityID = @ActivityID

GO	