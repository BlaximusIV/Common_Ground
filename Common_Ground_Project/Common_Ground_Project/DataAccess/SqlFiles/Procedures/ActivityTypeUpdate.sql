USE MASTER
GO

CREATE PROCEDURE dbo.ActivityTypeUpdate
(
	@ActivityTypeID INT,
	@Name VARCHAR(50), 
	@Description VARCHAR(MAX)
)
AS 
	SET NOCOUNT ON;

	UPDATE  Master.dbo.ActivityType
	SET
		Name = @Name, 
		Description = @Description
	WHERE
		ActivityTypeID = @ActivityTypeID
	
GO	