USE MASTER
GO

CREATE PROCEDURE dbo.IndividualInsert
(
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
	@IsMediaReleased BIT = 0, 
	@NewID INT OUTPUT
)
AS 
	SET NOCOUNT ON;

	INSERT INTO Master.dbo.Individual 
	(
		IndividualTypeID, 
		LastName, 
		FirstName, 
		PhoneNumber, 
		Email, 
		StreetAddress, 
		City, 
		State, 
		ZipCode, 
		Birthday, 
		IsFrequentCaller, 
		IsWaiverSigned, 
		IsMediaReleased
	)
	VALUES
	(
		@IndividualTypeID, 
		@LastName, 
		@FirstName, 
		@PhoneNumber, 
		@Email, 
		@StreetAddress, 
		@City, 
		@State, 
		@ZipCode, 
		@Birthday, 
		@IsFrequentCaller, 
		@IsWaiverSigned, 
		@IsMediaReleased
	)

	SET @NewID = SCOPE_IDENTITY()

GO	