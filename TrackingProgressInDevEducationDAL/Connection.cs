using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL
{
    public class Connection
    {
        private static string _cS = @"Persist Security Info=False;User ID=DevEd;Password=qqq!11;Initial Catalog=Sandbox;Server=80.78.240.16";
        public static List<T> Connect<T>(IQuery query)
        {
            using (IDbConnection dbConnection = new SqlConnection(_cS))
            {
                return dbConnection.Query<T>($"exec {query.Name} {query.Params}").AsList<T>();
            }
        }
       
    }
}