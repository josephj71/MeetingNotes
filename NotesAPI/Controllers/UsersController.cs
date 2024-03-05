using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotesDataAccess.DataServices;
using NotesDataAccess.Models;

namespace NotesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserDataService dataService;

        public UsersController(IUserDataService data)
        {
            this.dataService = data;
        }

        [HttpGet]
        public async Task<IResult> GetUsers()
        {
            try
            {
                return Results.Ok(await dataService.GetUsers());
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        [HttpGet("/Users/{id}")]
        public async Task<IResult> GetUser(int id)
        {
            try
            {
                var results =  await dataService.GetUsers();
                return results == null ? Results.NotFound() : Results.Ok(results);
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IResult> AddUser(UserModel user)
        {
            try
            {
                await dataService.InsertUser(user);
                return Results.Ok();
            }
            catch (Exception ex)
            {
               return Results.Problem(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IResult> UpdateUser(UserModel user)
        {
            try
            {
                await dataService.UpdateUser(user);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }


        [HttpDelete]
        public async Task<IResult> DeleteUser(int id)
        {
            try
            {
                await dataService.DeleteUser(id);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

    }
}
