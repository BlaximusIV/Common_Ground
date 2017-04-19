USE MASTER
GO

CREATE PROCEDURE dbo.VehicleGetByID
(
	@VehicleID INT
)
AS 
	SET NOCOUNT ON;

	SELECT
		VehicleID, 
		Name, 
		Description, 
		VIN
	FROM
		Master.dbo.Vehicle
	WHERE
		VehicleID = @VehicleID

GO	