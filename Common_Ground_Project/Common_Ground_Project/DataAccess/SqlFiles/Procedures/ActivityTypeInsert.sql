USE MASTER
GO

CREATE PROCEDURE dbo.ActivityTypeInsert
(
	@Name VARCHAR(50), 
	@Description VARCHAR(MAX), 
	@NewID INT OUTPUT
)
AS 
	SET NOCOUNT ON;

	INSERT INTO  Master.dbo.ActivityType
	(
		Name, 
		Description
	)
	VALUES
	(
		@Name, 
		@Description
	)

	SET @NewID = SCOPE_IDENTITY()
	
GO	