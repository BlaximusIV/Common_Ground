USE MASTER
GO

CREATE PROCEDURE dbo.ActivityGetByDate
(
	@Date DATETIME
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
	WHERE
		CONVERT(DATE, a.StartDate) = CONVERT(DATE, @Date)

GO	