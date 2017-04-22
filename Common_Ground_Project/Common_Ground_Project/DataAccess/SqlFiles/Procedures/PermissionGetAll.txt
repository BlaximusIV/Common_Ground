USE MASTER
GO

CREATE PROCEDURE dbo.PermissionGetAll
AS 
	SET NOCOUNT ON;

	SELECT 
		PermissionID, 
		Name, 
		IsAllowedEntry
	FROM
		Master.dbo.Permission
	
GO	