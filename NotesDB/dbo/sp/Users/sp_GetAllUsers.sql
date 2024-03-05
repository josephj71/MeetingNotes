CREATE PROCEDURE [dbo].[sp_GetAllUsers]
AS
	SELECT ID, FirstName, LastName
	From Users
RETURN 0
