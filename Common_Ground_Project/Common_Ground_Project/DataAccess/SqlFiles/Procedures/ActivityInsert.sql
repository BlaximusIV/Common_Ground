USE MASTER
GO

CREATE PROCEDURE dbo.ActivityInsert
(
	@ActivityTypeID INT, 
	@TripLeaderID INT, 
	@Location VARCHAR(50), 
	@StartDate DATETIME, 
	@EndDate DATETIME, 
	@PickUpTime TIME, 
	@DropOffTime TIME, 
	@StaffArrivalTime TIME, 
	@Cost DECIMAL, 
	@NewID INT OUTPUT
)
AS 
	SET NOCOUNT ON;

	INSERT INTO Master.dbo.Activity
	(
		ActivityTypeID, 
		TripLeaderID, 
		Location, 
		StartDate, 
		EndDate, 
		PickUpTime, 
		DropOffTime, 
		StaffArrivalTime, 
		Cost
	)
	VALUES 
	(
		@ActivityTypeID, 
		@TripLeaderID, 
		@Location, 
		@StartDate, 
		@EndDate, 
		@PickUpTime, 
		@DropOffTime, 
		@StaffArrivalTime, 
		@Cost
	)

	SET @NewID = SCOPE_IDENTITY()

GO	