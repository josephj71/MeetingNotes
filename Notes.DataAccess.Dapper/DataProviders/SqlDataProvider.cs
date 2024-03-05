using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace NotesDataAccess.DataProviders
{
    public class SqlDataProvider : ISqlDataProvider
    {
        private readonly IConfiguration _config;

        public SqlDataProvider(IConfiguration config)
        {
            _config = config;
        }

        public async Task<IEnumerable<T>> LoadData<T, P>(string storedProc, P parameters, string connStrId = "Default")
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connStrId));

            return await connection.QueryAsync<T>(storedProc, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task SaveData<T>(string storedProc, T parameters, string connStrId = "Default")
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connStrId));

            await connection.ExecuteAsync(storedProc, parameters, commandType: CommandType.StoredProcedure);
        }
    }
}
