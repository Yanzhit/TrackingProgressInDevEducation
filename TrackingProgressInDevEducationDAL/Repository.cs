using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Dapper;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL
{
    public class Repository
    {
        private readonly IDbConnection _dbConnection;

        public Repository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task SetAsync<T>(IQuery query)
        {
            await _dbConnection.QueryAsync<T>($"{query.Schema}{query.Name} {query.Params}");
        }

        public async Task<IEnumerable<T>> GetAsync<T>(IQuery query)
        {
            return await _dbConnection.QueryAsync<T>($"{query.Schema}{query.Name} {query.Params}");
        }

        public async Task<IEnumerable<T>> UpdateAsync<T>(IQuery query)
        {
            return await _dbConnection.QueryAsync<T>($"{query.Schema}{query.Name} {query.Params}");
            
        }

        public async Task<IEnumerable<T>> RemoveAsync<T>(IQuery query)
        {
            return await _dbConnection.QueryAsync<T>($"{query.Schema}{query.Name} {query.Params}");
        }

        public async Task<IEnumerable<T>> NullifyAsync<T>(IQuery query)
        {
            return await _dbConnection.QueryAsync<T>($"{query.Schema}{query.Name} {query.Params}");
        }
    }
}