using System.Collections.Generic;
using System.Data;
using Dapper;

namespace TrackingProgressInDevEducationDAL.Repositories
{
    public class Setter //: ASingle
    {
        public static T Single<T>(IDbConnection connection, string command)
        {
            return connection.QuerySingle<T>(command);
        }

        public static IEnumerable<T> Several<T>(IDbConnection connection, string command)
        {
            return connection.Query<T>(command);
        }
    }
}