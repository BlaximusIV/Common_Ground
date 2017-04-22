USE MASTER
GO

CREATE PROCEDURE dbo.ActivityUpdate
(
	@ActivityID INT,
	@ActivityTypeID INT, 
	@TripLeaderID INT, 
	@Location VARCHAR(50), 
	@StartDate DATETIME, 
	@EndDate DATETIME, 
	@PickUpTime TIME, 
	@DropOffTime TIME, 
	@StaffArrivalTime TIME, 
	@Cost DECIMAL
)
AS 
	SET NOCOUNT ON;

	UPDATE Master.dbo.Activity
	SET 
		ActivityTypeID = @ActivityTypeID, 
		TripLeaderID = @TripLeaderID, 
		[Location] = @Location, 
		StartDate = @StartDate, 
		EndDate = @EndDate, 
		PickUpTime = @PickUpTime, 
		DropOffTime = @DropOffTime, 
		StaffArrivalTime = @StaffArrivalTime, 
		Cost = @Cost
	WHERE
		ActivityID = @ActivityID

GO	