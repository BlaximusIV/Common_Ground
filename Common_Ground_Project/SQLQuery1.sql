CREATE PROCEDURE [dbo].[activityGridView1]
@Title varchar(50)
AS
    SELECT *
    FROM Activity
    WHERE Title LIKE @Title+'%';