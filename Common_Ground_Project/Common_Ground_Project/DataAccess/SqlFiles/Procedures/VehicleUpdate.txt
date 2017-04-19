USE MASTER
GO

CREATE PROCEDURE dbo.VehicleUpdate
(
	@VehicleID INT,
	@Name VARCHAR(50), 
	@Description VARCHAR(250), 
	@VIN VARCHAR(20)
)
AS 
	SET NOCOUNT ON;

	UPDATE Master.dbo.Vehicle
	SET
		Name = @Name, 
		Description = @Description, 
		VIN = @VIN
	WHERE
		VehicleID = @VehicleID

GO	