USE MASTER
GO

CREATE PROCEDURE dbo.IndividualNoteGetByID
(
	@IndividualNoteID INT
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
		IndividualNoteID = @IndividualNoteID

GO	