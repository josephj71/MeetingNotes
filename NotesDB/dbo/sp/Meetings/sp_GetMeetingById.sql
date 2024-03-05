CREATE PROCEDURE [dbo].[sp_GetMeetingById]
	@MeetingId int
AS
	SELECT ID, MeetingName, Description, MeetingDate
	From Meetings
	Where Id = @MeetingId
RETURN 0
