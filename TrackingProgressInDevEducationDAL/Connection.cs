using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using Dapper;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL
{
    public static class Connection
    {
        private const string Cs = @"Persist Security Info=False;User ID=DevEd;Password=qqq!11;Initial Catalog=Sandbox.Test;Server=80.78.240.16";
        //private const string Cs = @"Persist Security Info=False;User ID=DevEd;Password=qqq!11;Initial Catalog=Sandbox;Server=80.78.240.16";
        public static IDbConnection DbConnection { get; set; }

        public static void Connect()
        {
            IDbConnection dbConnection = new SqlConnection(Cs);
            DbConnection = dbConnection;
        }
        
        public static void Disconnect()
        {
            DbConnection.Dispose();
        }
    }
}