using System.Collections.Generic;
using System.Data;
using Dapper;

namespace TrackingProgressInDevEducationDAL.Repositories
{
    public class Getter : ASingle
    {
        public static IEnumerable<T> Several<T>(IDbConnection connection, string command)
        {
            return connection.Query<T>(command);
        }
    }
}