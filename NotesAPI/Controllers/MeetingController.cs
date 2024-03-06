using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotesDataAccess.DataServices;
using NotesDataAccess.Models;

namespace NotesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingController : ControllerBase
    {
        private readonly IMeetingDataService dataService;

        public MeetingController(IMeetingDataService data)
        {
            this.dataService = data;
        }

        [HttpGet]
        public async Task<IResult> GetMeetings()
        {
            try
            {
                return Results.Ok(await dataService.GetMeetings());
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IResult> GetMeeting(int id)
        {
            try
            {
                var results = await dataService.GetMeeting(id);
                return results == null ? Results.NotFound() : Results.Ok(results);
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IResult> AddMeeting(MeetingModel meeting)
        {
            try
            {
                await dataService.InsertMeeting(meeting);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IResult> UpdateMeeting(MeetingModel meeting)
        {
            try
            {
                await dataService.UpdateMeeting(meeting);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }


        [HttpDelete]
        public async Task<IResult> DeleteMeeting(int id)
        {
            try
            {
                await dataService.DeleteMeeting(id);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
