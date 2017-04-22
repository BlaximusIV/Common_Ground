USE MASTER
GO

CREATE PROCEDURE dbo.ActivityTypeGetAll
AS 
	SET NOCOUNT ON;

	SELECT 
		ActivityTypeID, 
		Name, 
		Description
	FROM
		Master.dbo.ActivityType
	
GO	