CREATE PROCEDURE [dbo].[sp_UpdateMeeting]
	@MeetingId int,
	@MeetingName varchar(50),
	@Description varchar(max),
	@MeetingDate datetime2(7)
AS
	Update Meetings
	Set MeetingName = @MeetingName, Description = @Description, MeetingDate = @MeetingDate
	Where ID = @MeetingId
RETURN 0
