USE MASTER
GO

CREATE PROCEDURE dbo.IndividualGetAll
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
		IsMediaReleased
	FROM
		Master.dbo.Individual i

GO	