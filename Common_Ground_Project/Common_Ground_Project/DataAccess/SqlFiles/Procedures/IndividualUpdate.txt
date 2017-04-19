USE MASTER
GO

CREATE PROCEDURE dbo.IndividualUpdate
(
	@IndividualID INT,
	@IndividualTypeID INT, 
	@LastName VARCHAR(50), 
	@FirstName VARCHAR(50), 
	@PhoneNumber VARCHAR(15) = '', 
	@Email VARCHAR(50) = '', 
	@StreetAddress VARCHAR(50) = '', 
	@City VARCHAR(50) = '', 
	@State VARCHAR(2) = '', 
	@ZipCode INT = 0, 
	@Birthday DATE = '1900-01-01', 
	@IsFrequentCaller BIT = 0, 
	@IsWaiverSigned BIT = 0, 
	@IsMediaReleased BIT = 0
)
AS 
	SET NOCOUNT ON;

	UPDATE Master.dbo.Individual 
	SET
		IndividualTypeID = @IndividualTypeID, 
		LastName = @LastName, 
		FirstName = @FirstName, 
		PhoneNumber = @PhoneNumber, 
		Email = @Email, 
		StreetAddress = @StreetAddress, 
		City = @City, 
		State = @State, 
		ZipCode = @ZipCode, 
		Birthday = @Birthday, 
		IsFrequentCaller = @IsFrequentCaller, 
		IsWaiverSigned = @IsWaiverSigned, 
		IsMediaReleased = @IsMediaReleased
	WHERE
		IndividualID = @IndividualID

GO	