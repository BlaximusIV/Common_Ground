USE MASTER
GO

CREATE PROCEDURE dbo.VehicleGetAll
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
		IsInUse = 1

GO	