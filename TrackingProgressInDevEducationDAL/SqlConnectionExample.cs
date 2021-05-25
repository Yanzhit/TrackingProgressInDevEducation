using System;
using System.Data.SqlClient;

namespace TrackingProgressInDevEducationDAL
{
    public class SqlConnectionExample
    {
        public void Connect()
        {
            string cS = @"Data Source=.\;Initial Catalog=TrackingProgressInDevEducationDB;Integrated Security=True";
            string q = "Select * from Order";

            using (SqlConnection sqlConnection = new SqlConnection(cS))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(q, sqlConnection);

                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    Console.WriteLine(dataReader.GetName(0) + " "
                    + dataReader.GetName(1) + " "
                    + dataReader.GetName(2) + " ");

                    while (dataReader.Read())
                    {
                        Console.WriteLine(dataReader["id"]);
                        Console.WriteLine(dataReader.GetValue(1));
                        Console.WriteLine(dataReader.GetValue(2));
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}