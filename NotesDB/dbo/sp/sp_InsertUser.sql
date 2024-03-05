CREATE PROCEDURE [dbo].[sp_InsertUser]
	@fname varchar(50),
	@lname varchar(50)
AS
	Insert into Users (FirstName, LastName)
	Values (@fname, @lname)
RETURN 0
