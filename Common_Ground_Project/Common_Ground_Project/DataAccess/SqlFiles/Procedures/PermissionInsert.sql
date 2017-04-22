USE MASTER
GO

CREATE PROCEDURE dbo.PermissionInsert
(
	@Name VARCHAR(50), 
	@IsAllowedEntry BIT, 
	@NewID INT OUTPUT
)
AS 
	SET NOCOUNT ON;

	INSERT INTO  Master.dbo.Permission
	(
		Name, 
		IsAllowedEntry
	)
	VALUES
	(
		@Name, 
		@IsAllowedEntry
	)

	SET @NewID = SCOPE_IDENTITY()
	
GO	