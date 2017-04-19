USE MASTER
GO

CREATE PROCEDURE dbo.ActivityNoteGetByActivity
(
	@ActivityID INT
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
		ActivityID = @ActivityID

GO	