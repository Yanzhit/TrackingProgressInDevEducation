using System;
using System.Data;
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

        protected void Disconnect(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
            Dispose();
        }
        protected string ConfigCommand(IQuery query)
        {
            return $"{Exec}{Gap}{Schema}{Point}{query.Name}{Gap}{query.Params}";
        }
    }
}