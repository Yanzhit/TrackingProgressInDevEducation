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
        private static string _cS = @"Data Source=.\;Initial Catalog=TrackingProgressInDevEducationDB;Integrated Security=True";
        public static List<T> Connect<T>(IQuery query)
        {
            using (IDbConnection dbConnection = new SqlConnection(_cS))
            {
                return dbConnection.Query<T>($"exec {query.Name} {query.Params}").AsList<T>();
            }
        }
       
    }
}