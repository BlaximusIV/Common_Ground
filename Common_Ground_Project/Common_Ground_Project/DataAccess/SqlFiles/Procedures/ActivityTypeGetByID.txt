USE MASTER
GO

CREATE PROCEDURE dbo.ActivityTypeGetByID
(
	@ActivityTypeID INT
)
AS 
	SET NOCOUNT ON;

	SELECT 
		ActivityTypeID, 
		Name, 
		Description
	FROM
		Master.dbo.ActivityType
	WHERE
		ActivityTypeID = @ActivityTypeID
	
GO	