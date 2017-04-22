USE MASTER
GO

CREATE PROCEDURE dbo.EmergencyContactGetByIndividual
(
	@IndividualID INT
)
AS 
	SET NOCOUNT ON;

	SELECT
		EmergencyContactID, 
		IndividualID, 
		Name, 
		Phone, 
		Email
	FROM
		Master.dbo.EmergencyContact
	WHERE
		IndividualID = @IndividualID

GO	