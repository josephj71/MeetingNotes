using NotesDataAccess.Models;

namespace NotesDataAccess.DataServices
{
    public interface IUserDataService
    {
        Task DeleteUser(int id);
        Task<UserModel?> GetUser(int id);
        Task<IEnumerable<UserModel>> GetUsers();
        Task InsertUser(UserModel user);
        Task UpdateUser(UserModel user);
    }
}