using NotesDataAccess.DataProviders;
using NotesDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesDataAccess.DataServices
{
    public class MeetingDataService : IMeetingDataService
    {
        private readonly ISqlDataProvider sqlDataProvider;

        public MeetingDataService(ISqlDataProvider sqlDataProvider)
        {
            this.sqlDataProvider = sqlDataProvider;
        }

        public async Task<IEnumerable<MeetingModel>> GetMeetings()
        {
            return await sqlDataProvider.LoadData<MeetingModel, dynamic>("dbo.sp_GetAllMeetings", new { });
        }

        public async Task<MeetingModel?> GetMeeting(int id)
        {
            var result = await sqlDataProvider.LoadData<MeetingModel, dynamic>("dbo.sp_GetMeetingById", new { MeetingId = id });

            return result.FirstOrDefault();
        }

        public async Task InsertMeeting(MeetingModel meeting)
        {
            await sqlDataProvider.SaveData("dbo.sp_InsertMeeting", new { meeting.MeetingName, meeting.Description, meeting.MeetingDate });
        }

        public async Task UpdateMeeting(MeetingModel meeting)
        {
            await sqlDataProvider.SaveData("dbo.sp_UpdateMeeting", meeting);
        }

        public async Task DeleteMeeting(int id)
        {
            await sqlDataProvider.SaveData("dbo.sp_DeleteMeeting", new { MeetingId = id });
        }
    }
}
