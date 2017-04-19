CREATE TRIGGER IndividualNoteUpdate ON IndividualNote
AFTER INSERT, UPDATE
AS UPDATE DBO.IndividualNote
SET [DateTime] = GETDATE()
FROM INSERTED I 
	JOIN DBO.IndividualNote IA ON IA.IndividualNoteID = I.IndividualNoteID
GO

CREATE TRIGGER ActivityNoteUpdate ON ActivityNote
AFTER INSERT, UPDATE
AS UPDATE DBO.ActivityNote
SET [DateTime] = GETDATE()
FROM INSERTED I 
	JOIN DBO.ActivityNote AN ON AN.ActivityNoteID = I.ActivityNoteID
GO