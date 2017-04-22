USE MASTER
GO

CREATE PROCEDURE dbo.StaffGetByID
(
	@IndividualID INT
)
AS 
	SET NOCOUNT ON;

	SELECT
		i.IndividualID, 
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
		IsMediaReleased, 

		s.Username, 
		s.HireDate, 
		s.LeaveDate, 
		s.PermissionID, 
		s.IsEligibleDriver, 
		s.IsEmployeed
	FROM
		Master.dbo.Individual i 
		JOIN Master.dbo.Staff s ON s.IndividualID = i.IndividualID
	WHERE
		i.IndividualID = @IndividualID

GO	