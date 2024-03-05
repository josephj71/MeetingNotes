CREATE PROCEDURE [dbo].[sp_GetAllMeetings]
AS
	SELECT ID, MeetingName, Description, MeetingDate
	From Meetings
RETURN 0
