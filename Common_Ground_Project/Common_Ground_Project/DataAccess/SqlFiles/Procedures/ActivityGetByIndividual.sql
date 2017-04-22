USE MASTER
GO

CREATE PROCEDURE dbo.ActivityGetByIndividual
(
	@IndividualID INT
)
AS 
	SET NOCOUNT ON;

	SELECT
		a.ActivityID, 
		a.ActivityTypeID,
		a.TripLeaderID, 
		a.Location, 
		a.StartDate, 
		a.EndDate, 
		a.PickUpTime, 
		a.DropOffTime, 
		a.StaffArrivalTime, 
		a.Cost, 

		at.Name [ActivityTypeName], 
		at.[Description] [ActivityTypeDescription]
	FROM
		Master.dbo.Activity a
		JOIN Master.dbo.ActivityType at ON at.ActivityTypeID = a.ActivityTypeID
		JOIN Master.dbo.IndividualActivity ia ON ia.ActivityID = a.ActivityID
	WHERE
		IndividualID = @IndividualID

GO	