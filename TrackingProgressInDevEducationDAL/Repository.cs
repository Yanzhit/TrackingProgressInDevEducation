using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Dapper;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL
{
    public static class Repository
    {
        private static readonly IDbConnection DBConnection = Connection.DbConnection;

        public static T SetOneAsync<T>(IQuery query)
        {
            return DBConnection.QuerySingle<T>($"{query.Schema}{query.Name} {query.Params}");
        }

        public static T GetOneAsync<T>(IQuery query)
        {
            return DBConnection.QuerySingle<T>($"{query.Schema}{query.Name} {query.Params}");
        }

        public static T UpdateOneAsync<T>(IQuery query)
        {
            return DBConnection.QuerySingle<T>($"{query.Schema}{query.Name} {query.Params}");
        }

        public static T RemoveOneAsync<T>(IQuery query)
        {
            return DBConnection.QuerySingle<T>($"{query.Schema}{query.Name} {query.Params}");
        }

        public static IEnumerable<T> SetSeveralAsync<T>(IQuery query)
        {
            return DBConnection.Query<T>($"{query.Schema}{query.Name} {query.Params}").AsList();
        }

        public static IEnumerable<T> GetSeveralAsync<T>(IQuery query)
        {
            return DBConnection.Query<T>($"{query.Schema}{query.Name} {query.Params}").AsList();
        }

        public static IEnumerable<T> UpdateSeveralAsync<T>(IQuery query)
        {
            return DBConnection.Query<T>($"{query.Schema}{query.Name} {query.Params}").AsList();
            
        }

        public static IEnumerable<T> RemoveSeveralAsync<T>(IQuery query)
        {
            return DBConnection.Query<T>($"{query.Schema}{query.Name} {query.Params}").AsList();
        }

        public static IEnumerable<T> NullifyAsync<T>(IQuery query)
        {
            return DBConnection.Query<T>($"{query.Schema}{query.Name} {query.Params}").AsList();
        }
    }
}