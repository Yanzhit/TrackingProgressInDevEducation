using System.Collections.Generic;
using System.Data;
using Dapper;

namespace TrackingProgressInDevEducationDAL.Repositories
{
    public abstract class ARepository
    {
        protected ARepository()
        {
        }

        public virtual T Single<T>(IDbConnection connection,  string command)
        {
            try
            {
                return connection.QuerySingle<T>(command);
            }
            catch
            {
                return default(T);
            }
        }

        public virtual IEnumerable<T> Several<T>(IDbConnection connection, string command)
        {
            try
            {
                return connection.Query<T>(command);
            }
            catch
            {
                return default(IEnumerable<T>);
            }
        }
    }
}