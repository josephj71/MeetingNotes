CREATE PROCEDURE [dbo].[sp_DeleteMeeting]
	@MeetingId int
AS
	Delete
	From Meetings
	Where ID = @MeetingId
RETURN 0
