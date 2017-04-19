USE MASTER
GO

CREATE PROCEDURE dbo.IndividualActivityInsert
(
	@IndividualID INT, 
	@ActivityID INT
)
AS 
	SET NOCOUNT ON;

	INSERT INTO Master.dbo.IndividualActivity
	(
		IndividualID, 
		ActivityID
	)
	VALUES
	(
		@IndividualID, 
		@ActivityID
	)

GO	