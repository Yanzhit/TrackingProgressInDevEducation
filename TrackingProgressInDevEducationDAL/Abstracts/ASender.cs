using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;
using static TrackingProgressInDevEducationDAL.Defines;

namespace TrackingProgressInDevEducationDAL.Abstracts
{
    public abstract class ASender : IDisposable
    {
        private IDbConnection _dbConnection;
        
        public void Dispose()
        {
            _dbConnection?.Dispose();
        }
        
        protected object Refraction(IQuery query, IDbConnection dbConnection, MethodInfo method)
        {
            string command = ConfigCommand(query);
            MethodInfo generic = method.MakeGenericMethod(query.Type);
            object obj = generic.Invoke(null, new object[] {dbConnection, command});
            Disconnect(dbConnection);
            return obj;
        }

        private void Disconnect(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
            Dispose();
        }

        private string ConfigCommand(IQuery query)
        {
            return $"{Exec}{Gap}{Schema}{Point}{query.Name}{Gap}{query.Params}";
        }
    }
}