USE MASTER
GO

CREATE PROCEDURE dbo.ActivityNoteInsert
(
	@ActivityID INT, 
	@Note VARCHAR(MAX),
	@NewID INT OUTPUT
)
AS 
	SET NOCOUNT ON;

	INSERT INTO Master.dbo.ActivityNote
	(
		ActivityID, 
		Note, 
		DateTime
	)
	VALUES
	(
		@ActivityID, 
		@Note, 
		GETDATE()
	)

	SET @NewID = SCOPE_IDENTITY()

GO	