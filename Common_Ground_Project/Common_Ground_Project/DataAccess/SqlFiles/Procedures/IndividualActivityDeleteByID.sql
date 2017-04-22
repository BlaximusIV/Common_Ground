USE MASTER
GO

CREATE PROCEDURE dbo.IndividualActivityDelete
(
	@IndividualID INT, 
	@ActivityID INT
)
AS 
	SET NOCOUNT ON;

	DELETE 
	FROM Master.dbo.IndividualActivity
	WHERE
		IndividualID = @IndividualID 
		AND ActivityID = @ActivityID

GO	