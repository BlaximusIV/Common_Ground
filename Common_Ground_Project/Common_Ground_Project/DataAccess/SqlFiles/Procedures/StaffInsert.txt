USE MASTER
GO

CREATE PROCEDURE dbo.StaffInsert
(
	@IndividualID INT,
	@Username VARCHAR(50), 
	@Password NVARCHAR(255),
	@HireDate DATETIME = NULL, 
	@LeaveDate DATETIME = NULL, 
	@PermissionID INT = 1, 
	@IsEligibleDriver BIT = 0, 
	@IsEmployeed BIT = 1
)
AS 
	SET NOCOUNT ON;

	INSERT INTO Master.dbo.Staff
	(
		IndividualID,
		Username, 
		Password, 
		HireDate, 
		LeaveDate, 
		PermissionID, 
		IsEligibleDriver, 
		IsEmployeed
	)
	VALUES
	(
		@IndividualID,
		@Username, 
		@Password, 
		@HireDate, 
		@LeaveDate, 
		@PermissionID, 
		@IsEligibleDriver, 
		@IsEmployeed
	)

GO	