USE MASTER
GO

CREATE PROCEDURE dbo.EmergencyContactGetByID
(
	@EmergencyContactID INT
)
AS 
	SET NOCOUNT ON;

	SELECT
		EmergencyContactID, 
		ParticipantID, 
		Name, 
		Phone, 
		Email
	FROM
		Master.dbo.EmergencyContact
	WHERE
		EmergencyContactID = @EmergencyContactID

GO	