CREATE PROCEDURE [dbo].[sp_UpdateUser]
	@UID int,
	@fname varchar(50),
	@lname varchar(50)
AS
	Update Users
	Set FirstName = @fname, LastName = @lname
	Where ID = @UID
RETURN 0
