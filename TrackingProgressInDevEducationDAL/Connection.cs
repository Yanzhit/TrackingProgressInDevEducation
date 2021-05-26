﻿using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace TrackingProgressInDevEducationDAL
{
    public class Connection
    {
        private static string _cS = @"Data Source=.\;Initial Catalog=TrackingProgressInDevEducationDB;Integrated Security=True";
        public static List<T> Connect<T>(string query)
        {
            using (IDbConnection dbConnection = new SqlConnection(_cS))
            {
                return dbConnection.Query<T>(query).AsList<T>();
            }
        }
    }
}