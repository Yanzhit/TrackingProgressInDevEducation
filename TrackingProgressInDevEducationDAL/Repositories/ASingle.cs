using System.Data;
using Dapper;

namespace TrackingProgressInDevEducationDAL.Repositories
{
    public abstract class ASingle
    {
        public static T Single<T>(IDbConnection connection, string command)
        {
            return connection.QuerySingle<T>(command);
        }
    }
}