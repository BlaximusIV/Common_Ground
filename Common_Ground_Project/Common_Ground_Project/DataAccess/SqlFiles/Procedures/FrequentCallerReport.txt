USE MASTER
GO

CREATE PROCEDURE dbo.FrequentCallerReport
AS 
	SET NOCOUNT ON;

	SELECT	
		i.FirstName, 
		i.LastName, 
		i.PhoneNumber, 
		i.Email, 
		i.IsFrequentCaller, 
		i.IsMediaReleased, 
		i.IsWaiverSigned, 
		it.Name [Type]
	FROM
		Individual i 
		JOIN IndividualType it ON it.IndividualTypeID = i.IndividualTypeID
	WHERE
		i.IsFrequentCaller = 1
		

GO	