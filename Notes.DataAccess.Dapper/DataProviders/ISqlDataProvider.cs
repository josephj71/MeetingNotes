
namespace NotesDataAccess.DataProviders
{
    public interface ISqlDataProvider
    {
        Task<IEnumerable<T>> LoadData<T, P>(string storedProc, P parameters, string connStrId = "Default");
        Task SaveData<T>(string storedProc, T parameters, string connStrId = "Default");
    }
}