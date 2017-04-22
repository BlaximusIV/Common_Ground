USE MASTER
GO

CREATE PROCEDURE dbo.StaffUpdate
(
	@IndividualID INT,
	@Username VARCHAR(50) = NULL, 
	@HireDate DATETIME = NULL, 
	@LeaveDate DATETIME = NULL, 
	@PermissionID INT = 1, 
	@IsEligibleDriver BIT = 0, 
	@IsEmployeed BIT = 1
)
AS 
	SET NOCOUNT ON;

	UPDATE Master.dbo.Staff
	SET
		Username = ISNULL(@Username, Username), 
		HireDate = @HireDate, 
		LeaveDate = @LeaveDate, 
		PermissionID = @PermissionID, 
		IsEligibleDriver = @IsEligibleDriver, 
		IsEmployeed = @IsEmployeed
	WHERE
		IndividualID = @IndividualID

GO	