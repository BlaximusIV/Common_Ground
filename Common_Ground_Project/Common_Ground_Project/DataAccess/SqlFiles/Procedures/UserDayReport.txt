USE MASTER
GO

CREATE PROCEDURE dbo.UserDayReport
(
	@FromDate DATETIME, 
	@ToDate DATETIME
)
AS 
	SET NOCOUNT ON;

	SELECT 
		a.[Description], 
		COUNT(DISTINCT ia.IndividualID) [UserCount], 
		CONVERT(DATE, a.StartDate) [ActivityDate]
	FROM
		Master.dbo.Activity a 
		JOIN Master.dbo.IndividualActivity ia ON ia.ActivityID = a.ActivityID
	WHERE
		CONVERT(DATE, a.StartDate) >= @FromDate AND CONVERT(DATE, a.StartDate) <= @ToDate
	GROUP BY 
		a.[Description], 
		a.StartDate

GO	