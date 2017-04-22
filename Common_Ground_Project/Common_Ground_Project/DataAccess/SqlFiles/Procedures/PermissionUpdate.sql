USE MASTER
GO

CREATE PROCEDURE dbo.PermissionUpdate
(
	@PermissionID INT,
	@Name VARCHAR(50), 
	@IsAllowedEntry BIT
)
AS 
	SET NOCOUNT ON;

	UPDATE  Master.dbo.Permission
	SET
		Name = @Name, 
		IsAllowedEntry = @IsAllowedEntry
	WHERE
		PermissionID = @PermissionID
	
GO	