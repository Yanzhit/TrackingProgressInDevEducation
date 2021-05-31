using System.Collections.Generic;
using System.Data;
using Dapper;
using TrackingProgressInDevEducationDAL.Requests.Interface;
using static TrackingProgressInDevEducationDAL.Defines;

namespace TrackingProgressInDevEducationDAL
{
    public static class Repository
    {
        private static readonly IDbConnection DBConnection = Connection.DbConnection;
        private static string _command;

        public static T SetOneAsync<T>(IQuery query)
        {
            ConfigCommand(query);
            return DBConnection.QuerySingle<T>(_command);
        }

        public static T GetOneAsync<T>(IQuery query)
        {
            ConfigCommand(query);
            return DBConnection.QuerySingle<T>(_command);
        }

        public static T UpdateOneAsync<T>(IQuery query)
        {
            ConfigCommand(query);
            return DBConnection.QuerySingle<T>(_command);
        }

        public static T RemoveOneAsync<T>(IQuery query)
        {
            ConfigCommand(query);
            return DBConnection.QuerySingle<T>(_command);
        }

        public static IEnumerable<T> SetSeveralAsync<T>(IQuery query)
        {
            ConfigCommand(query);
            return DBConnection.Query<T>(_command).AsList();
        }

        public static IEnumerable<T> GetSeveralAsync<T>(IQuery query)
        {
            ConfigCommand(query);
            return DBConnection.Query<T>(_command).AsList();
        }

        public static IEnumerable<T> UpdateSeveralAsync<T>(IQuery query)
        {
            ConfigCommand(query);
            return DBConnection.Query<T>(_command).AsList();
        }

        public static IEnumerable<T> RemoveSeveralAsync<T>(IQuery query)
        {
            ConfigCommand(query);
            return DBConnection.Query<T>(_command).AsList();
        }

        public static IEnumerable<T> NullifyAsync<T>(IQuery query)
        {
            ConfigCommand(query);
            return DBConnection.Query<T>(_command).AsList();
        }

        private static void ConfigCommand(IQuery query)
        {
            _command = $"{Exec}{Gap}{Schema}{Point}{query.Name}{Gap}{query.Params}";
        }
    }
}