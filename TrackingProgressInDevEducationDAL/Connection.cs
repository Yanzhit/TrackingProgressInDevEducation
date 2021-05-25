using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace TrackingProgressInDevEducationDAL
{
    public class Connection
    {
        public List<test> L = new List<test>();
        public string sss;
        public void Connect()
        {
            
            int id = 1;
            string cS = @"Data Source=.\;Initial Catalog=TrackingProgressInDevEducationDB;Integrated Security=True";
            string q = "Select * from Students";// +
                       //"where id = 1";

            using (IDbConnection dbConnection = new SqlConnection(cS))
            {
                L = dbConnection.Query<test>(q, new {id}).AsList<test>();
                //L = dbConnection.Query</*Сюда дженерик*/>(q, new {id}).AsList<int>();
            }
        }
    }

    public class test
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Rate { get; set; }
    }
}