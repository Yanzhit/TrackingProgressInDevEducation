using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace TrackingProgressInDevEducationDAL
{
    public class SqlConnectionExampleV2
    {
        public void Connect()
        {
            List<int> L = new List<int>();
            int id = 1;
            string cS = @"Data Source=.\;Initial Catalog=TrackingProgressInDevEducationDB;Integrated Security=True";
            string q = "Select * from Order";

            using (IDbConnection dbConnection = new SqlConnection(cS))
            {
                L = dbConnection.Query<int/*Сюда дженерик*/>(q, new {id}).AsList<int>();
            }
        }
    }
}