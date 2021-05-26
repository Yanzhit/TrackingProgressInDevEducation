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
            List<IModels> L = new List<IModels>();


            using (IDbConnection dbConnection = new SqlConnection(cS))
            {
                return dbConnection.Query<T>(q, new { id }).AsList<T>();
                //return ll[0];
            }
        }
    }

    public class Test
    {
        public static List<IModels> Models { get; set; } = new List<IModels>();
        private Type[] _types = new[] { typeof(Students), typeof(Visits) };

        public void Connect(string q)
        {
            Type type = null;
            if (q == "Select * from Students")
            {
                type = _types[0];
            }

            if (q == "Select * from Visits")
            {
                type = _types[1];
            }

            MethodInfo method = typeof(Connection).GetMethod(nameof(Connection.Connect));
            MethodInfo generic = method.MakeGenericMethod(type);


            var result = generic.Invoke(null, new object[] {q});
            IModels mod = (IModels) result;
        }
    }
    
}