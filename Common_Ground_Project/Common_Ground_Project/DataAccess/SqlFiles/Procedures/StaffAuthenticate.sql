USE MASTER
GO

CREATE PROCEDURE dbo.StaffAuthenticate
(
	@Username VARCHAR(50), 
	@Password VARCHAR(50)
)
AS 
	SET NOCOUNT ON;

	SELECT 
		PermissionID
	FROM
		Master.dbo.Staff 
	WHERE 
		Username = @Username
		AND Password = @Password

GO	