using System;
using System.Data;
using System.Reflection;
using TrackingProgressInDevEducationDAL.Interfaces;
using TrackingProgressInDevEducationDAL.Repositories;
using static TrackingProgressInDevEducationDAL.Defines;
using Single = TrackingProgressInDevEducationDAL.Repositories.Single;

namespace TrackingProgressInDevEducationDAL
{
    public class QuerySettings : IDisposable
    {
        private IDbConnection _dbConnection;
        public object QuerySet(IQuery query)
        {
            Connect();
            MethodInfo method = SelectMetod(query.TypeQueries);
            MethodInfo generic = method.MakeGenericMethod(query.Type);
            string command = ConfigCommand(query);
            object objects = generic.Invoke(this, new object[] {_dbConnection, command});
            Disconnect();
            return objects;
        }

        private void Connect()
        {
            Connection connection = new();
            _dbConnection = connection.Connect();
        }

        private void Disconnect()
        {
            _dbConnection.Dispose();
        }

        private MethodInfo SelectMetod(TypeQueries type)
        {
            return type switch
            {
                TypeQueries.Single => typeof(Single).GetMethod(nameof(Single.Async)),
                TypeQueries.Several => typeof(Several).GetMethod(nameof(Several.Async)),
                TypeQueries.Nullify => typeof(Nullify).GetMethod(nameof(Nullify.Async)),
                _ => null
            };
        }

        private string ConfigCommand(IQuery query)
        {
            return $"{Exec}{Gap}{Schema}{Point}{query.Name}{Gap}{query.Params}";
        }

        public void Dispose()
        {
            _dbConnection?.Dispose();
        }
    }
}