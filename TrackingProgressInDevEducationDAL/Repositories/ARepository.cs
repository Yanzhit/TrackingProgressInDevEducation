using System;
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
            return connection.QuerySingle<T>(command);
        }

        public virtual IEnumerable<T> Several<T>(IDbConnection connection, string command)
        {
            return connection.Query<T>(command);
        }
    }
}