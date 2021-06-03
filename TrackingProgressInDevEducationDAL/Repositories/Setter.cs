using System.Collections.Generic;
using System.Data;
using Dapper;

namespace TrackingProgressInDevEducationDAL.Repositories
{
    public class Setter //: ASingle
    {
        public static IEnumerable<T> Single<T>(IDbConnection connection, string command)
        {
            //var retval = connection.Execute(command);
            var retval = connection.Query<T>(command);
            var result = retval.GetType().ContainsGenericParameters;
            return connection.Query<T>(command);
        }

        public static IEnumerable<T> Several<T>(IDbConnection connection, string command)
        {
            return connection.Query<T>(command);
        }
    }
}