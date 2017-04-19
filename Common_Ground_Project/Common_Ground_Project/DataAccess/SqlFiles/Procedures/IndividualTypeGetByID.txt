USE MASTER
GO

CREATE PROCEDURE dbo.IndividualTypeGetByID
(
	@IndividualTypeID INT
)
AS 
	SET NOCOUNT ON;

	SELECT 
		IndividualTypeID, 
		Name
	FROM
		Master.dbo.IndividualType
	WHERE
		IndividualTypeID = @IndividualTypeID

GO	