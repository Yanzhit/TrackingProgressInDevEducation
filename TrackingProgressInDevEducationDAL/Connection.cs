using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using Dapper;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Interface;

namespace TrackingProgressInDevEducationDAL
{
    public class Connection
    {
        public static List<T> Connect<T>(string q)
        {
            string cS = @"Data Source=.\;Initial Catalog=TrackingProgressInDevEducationDB;Integrated Security=True";
            int id = 1;

            using (IDbConnection dbConnection = new SqlConnection(cS))
            {
                return dbConnection.Query<T>(q, new { id }).AsList<T>();
            }
        }
    }
}