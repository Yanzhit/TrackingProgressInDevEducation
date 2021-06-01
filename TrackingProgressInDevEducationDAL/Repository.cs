using System.Collections.Generic;
using System.Data;
using Dapper;
using TrackingProgressInDevEducationDAL.Requests.Interface;
using static TrackingProgressInDevEducationDAL.Defines;

namespace TrackingProgressInDevEducationDAL
{
    public class Repository
    {
        private static string _command;

        public static T SetOneAsync<T>(IQuery query, IDbConnection connection)
        {
            ConfigCommand(query);
            return connection.QuerySingle<T>(_command);
        }

        public static T GetOneAsync<T>(IQuery query, IDbConnection connection)
        {
            ConfigCommand(query);
            return connection.QuerySingle<T>(_command);
        }

        public static T UpdateOneAsync<T>(IQuery query, IDbConnection connection)
        {
            ConfigCommand(query);
            return connection.QuerySingle<T>(_command);
        }

        public static T RemoveOneAsync<T>(IQuery query, IDbConnection connection)
        {
            ConfigCommand(query);
            return connection.QuerySingle<T>(_command);
        }

        public static IEnumerable<T> SetSeveralAsync<T>(IQuery query, IDbConnection connection)
        {
            ConfigCommand(query);
            return connection.Query<T>(_command).AsList();
        }

        public static IEnumerable<T> GetSeveralAsync<T>(IQuery query, IDbConnection connection)
        {
            ConfigCommand(query);
            return connection.Query<T>(_command).AsList();
        }

        public static IEnumerable<T> UpdateSeveralAsync<T>(IQuery query, IDbConnection connection)
        {
            ConfigCommand(query);
            return connection.Query<T>(_command).AsList();
        }

        public static IEnumerable<T> RemoveSeveralAsync<T>(IQuery query, IDbConnection connection)
        {
            ConfigCommand(query);
            return connection.Query<T>(_command).AsList();
        }

        public static IEnumerable<T> NullifyAsync<T>(IQuery query, IDbConnection connection)
        {
            ConfigCommand(query);
            return connection.Query<T>(_command).AsList();
        }

        private static void ConfigCommand(IQuery query)
        {
            _command = $"{Exec}{Gap}{Schema}{Point}{query.Name}{Gap}{query.Params}";
        }
    }
}