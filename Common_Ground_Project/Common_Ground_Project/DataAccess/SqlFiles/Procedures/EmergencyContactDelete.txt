USE MASTER
GO

CREATE PROCEDURE dbo.EmergencyContactDelete
(
	@EmergencyContactID INT
)
AS 
	SET NOCOUNT ON;

	DELETE
	FROM Master.dbo.EmergencyContact
	WHERE
		EmergencyContactID = @EmergencyContactID

GO	