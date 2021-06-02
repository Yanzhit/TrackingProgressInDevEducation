using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;

namespace TrackingProgressInDevEducationDAL.Repositories
{
    public class Repository
    {
        public static T SingleAsync<T>(IDbConnection connection, string command)
        {
            return connection.QuerySingle<T>(command);
        }

        public static IEnumerable<T> SeveralAsync<T>(IDbConnection connection, string command)
        {
            return connection.Query<T>(command).AsList();
        }

        //public static IEnumerable<T> NullifyAsync<T>(IDbConnection connection, string command)
        //{
        //    return connection.Query<T>(command).AsList();
        //}
        public static async Task<IEnumerable<T>> NullifyAsync<T>(IDbConnection connection, string command)
        {
            return await connection.QueryAsync<T>(command);
        }

        public static async Task<T> NullifyAsynw<T>(IDbConnection connection, string command)
        {
            var res =  await connection.QuerySingleAsync<T>(command);
            return res;
        }
    }
}