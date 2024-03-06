using NotesDataAccess.Models;

namespace NotesDataAccess.DataServices
{
    public interface IMeetingDataService
    {
        Task DeleteMeeting(int id);
        Task<MeetingModel?> GetMeeting(int id);
        Task<IEnumerable<MeetingModel>> GetMeetings();
        Task InsertMeeting(MeetingModel meeting);
        Task UpdateMeeting(MeetingModel meeting);
    }
}