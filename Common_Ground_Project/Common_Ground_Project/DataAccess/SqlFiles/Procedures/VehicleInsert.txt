USE MASTER
GO

CREATE PROCEDURE dbo.VehicleInsert
(
	@Name VARCHAR(50), 
	@Description VARCHAR(250), 
	@VIN VARCHAR(20), 
	@NewID INT OUTPUT
)
AS 
	SET NOCOUNT ON;

	INSERT INTO Master.dbo.Vehicle
	(
		Name, 
		Description, 
		VIN
	)
	VALUES
	(
		@Name, 
		@Description, 
		@VIN
	)

	SET @NewID = SCOPE_IDENTITY()

GO	