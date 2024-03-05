CREATE PROCEDURE [dbo].[sp_InsertMeeting]
	@MeetingName varchar(50),
	@Description varchar(max),
	@MeetingDate datetime2(7)
AS
	Insert into Meetings (MeetingName, Description, MeetingDate)
	Values (@MeetingName, @Description, @MeetingDate)
RETURN 0
