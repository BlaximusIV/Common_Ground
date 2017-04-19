USE MASTER
GO

CREATE PROCEDURE dbo.ActivityDeleteByID
(
	@ActivityID INT
)
AS 
	SET NOCOUNT ON;

	DELETE 
	FROM Master.dbo.Activity
	WHERE
		ActivityID = @ActivityID

GO	