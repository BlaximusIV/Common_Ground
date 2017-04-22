USE MASTER
GO

CREATE PROCEDURE dbo.ActivityNoteGetByID
(
	@ActivityNoteID INT
)
AS 
	SET NOCOUNT ON;

	SELECT
		ActivityNoteID, 
		ActivityID, 
		Note, 
		DateTime
	FROM
		Master.dbo.ActivityNote
	WHERE
		ActivityNoteID = @ActivityNoteID

GO	