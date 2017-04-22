USE MASTER
GO

CREATE PROCEDURE dbo.IndividualGetByActivity
(
	@ActivityID INT
)
AS 
	SET NOCOUNT ON;

	SELECT
		i.IndividualID, 
		i.IndividualTypeID, 
		i.LastName, 
		i.FirstName, 
		i.PhoneNumber, 
		i.Email, 
		i.StreetAddress, 
		i.City, 
		i.State, 
		i.ZipCode, 
		i.Birthday, 
		i.IsFrequentCaller, 
		i.IsWaiverSigned, 
		i.IsMediaReleased
	FROM
		Master.dbo.Individual i
		JOIN Master.dbo.InvidiualActivity ia ON ia.IndividualID = i.IndividualID
	WHERE
		ActivityID = @ActivityID

GO	