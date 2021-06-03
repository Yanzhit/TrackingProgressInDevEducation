using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Repositories
{
    public abstract class ARepository
    {
        public ARepository()
        {
        }

        public T Single<T>(IDbConnection connection, string command)
        {
            return connection.QuerySingle<T>(command);
        }

        public IEnumerable<T> Several<T>(IDbConnection connection, string command)
        {
            return connection.Query<T>(command);
        }
    }
}