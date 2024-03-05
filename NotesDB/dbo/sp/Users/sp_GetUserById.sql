CREATE PROCEDURE [dbo].[sp_GetUserById]
	@UID int
AS
	SELECT ID, FirstName, LastName
	From Users
	Where ID = @UID
RETURN 0
