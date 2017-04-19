USE MASTER
GO

CREATE PROCEDURE dbo.IndividualDeleteByID
(
	@IndividualID INT
)
AS 
	SET NOCOUNT ON;

	DELETE
	FROM Master.dbo.Individual 
	WHERE 
		IndividualID = @IndividualID
	
GO	