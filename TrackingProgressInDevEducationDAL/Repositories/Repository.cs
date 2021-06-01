using System.Collections.Generic;
using System.Data;
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

        public static IEnumerable<T> NullifyAsync<T>(IDbConnection connection, string command)
        {
            return connection.Query<T>(command).AsList();
        }
    }
}