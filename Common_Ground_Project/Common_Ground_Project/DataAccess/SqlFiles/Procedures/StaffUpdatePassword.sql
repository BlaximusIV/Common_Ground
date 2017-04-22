USE MASTER
GO

CREATE PROCEDURE dbo.StaffUpdatePassword
(
	@IndividualID INT,
	@Password VARCHAR(50)
)
AS 
	SET NOCOUNT ON;

	UPDATE Master.dbo.Staff
	SET
		[Password] = @Password
	WHERE
		IndividualID = @IndividualID

GO	