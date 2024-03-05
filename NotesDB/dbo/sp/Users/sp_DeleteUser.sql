CREATE PROCEDURE [dbo].[sp_DeleteUser]
	@UID int
AS
	Delete
	From Users
	Where ID = @UID
RETURN 0
