USE MASTER
GO

CREATE PROCEDURE dbo.EmergencyContactInsert
(
	@IndividualID INT, 
	@Name VARCHAR(50), 
	@Phone VARCHAR(50), 
	@Email VARCHAR(50), 
	@NewID INT OUTPUT
)
AS 
	SET NOCOUNT ON;

	INSERT INTO Master.dbo.EmergencyContact
	(
		IndividualID, 
		Name, 
		Phone, 
		Email
	)
	VALUES 
	(
		@IndividualID, 
		@Name, 
		@Phone, 
		@Email
	)

	SET @NewID = SCOPE_IDENTITY()

GO	