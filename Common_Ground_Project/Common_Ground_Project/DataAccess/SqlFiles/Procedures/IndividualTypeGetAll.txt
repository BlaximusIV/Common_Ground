USE MASTER
GO

CREATE PROCEDURE dbo.IndividualTypeGetAll
AS 
	SET NOCOUNT ON;

	SELECT 
		IndividualTypeID, 
		Name
	FROM
		Master.dbo.IndividualType
	
GO	