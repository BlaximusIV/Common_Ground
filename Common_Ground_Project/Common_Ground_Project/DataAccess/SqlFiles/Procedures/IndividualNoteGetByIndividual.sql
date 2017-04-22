USE MASTER
GO

CREATE PROCEDURE dbo.IndividualNoteGetByIndividual
(
	@IndividualID INT
)
AS 
	SET NOCOUNT ON;

	SELECT
		IndividualNoteID, 
		IndividualID, 
		Note, 
		DateTime
	FROM
		Master.dbo.IndividualNote
	WHERE
		IndividualID = @IndividualID

GO	