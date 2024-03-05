using NotesDataAccess.DataProviders;
using NotesDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesDataAccess.DataServices
{
    public class UserDataService : IUserDataService
    {
        private readonly ISqlDataProvider sqlDataProvider;

        public UserDataService(ISqlDataProvider sqlDataProvider)
        {
            this.sqlDataProvider = sqlDataProvider;
        }

        public async Task<IEnumerable<UserModel>> GetUsers()
        {
            return await sqlDataProvider.LoadData<UserModel, dynamic>("dbo.sp_GetAllUsers", new { });
        }

        public async Task<UserModel?> GetUser(int id)
        {
            var result = await sqlDataProvider.LoadData<UserModel, dynamic>("dbo.sp_GetUserById", new { Id = id });

            return result.FirstOrDefault();
        }

        public async Task InsertUser(UserModel user)
        {
            await sqlDataProvider.SaveData("dbo.sp_InsertUser", new { user.FirstName, user.LastName });
        }

        public async Task UpdateUser(UserModel user)
        {
            await sqlDataProvider.SaveData("dbo.sp_UpdateUser", user);
        }

        public async Task DeleteUser(int id)
        {
            await sqlDataProvider.SaveData("dbo.sp_DeleteUser", new { id });
        }

    }
}
