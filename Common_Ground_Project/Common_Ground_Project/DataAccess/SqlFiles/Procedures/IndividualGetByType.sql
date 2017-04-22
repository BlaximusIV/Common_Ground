USE MASTER
GO

CREATE PROCEDURE dbo.IndividualGetByType
(
	@TypeID INT
)
AS 
	SET NOCOUNT ON;

	SELECT
		IndividualID, 
		IndividualTypeID, 
		LastName, 
		FirstName, 
		PhoneNumber, 
		Email, 
		StreetAddress, 
		City, 
		State, 
		ZipCode, 
		Birthday, 
		IsFrequentCaller, 
		IsWaiverSigned, 
		IsMediaReleased
	FROM
		Master.dbo.Individual 
	WHERE
		IndividualTypeID = @TypeID

GO	