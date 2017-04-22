USE MASTER
GO

CREATE PROCEDURE dbo.PermissionGetByID
(
	@PermissionID INT
)
AS 
	SET NOCOUNT ON;

	SELECT 
		PermissionID, 
		Name, 
		IsAllowedEntry
	FROM
		Master.dbo.Permission
	WHERE
		PermissionID = @PermissionID
	
GO	