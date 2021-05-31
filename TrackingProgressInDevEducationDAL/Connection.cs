using System.Data;
using System.Data.SqlClient;
using static TrackingProgressInDevEducationDAL.Defines;

namespace TrackingProgressInDevEducationDAL
{
    public static class Connection
    {
        private static readonly string Cs =
            $@"Persist Security Info={F};User ID={User};Password={Password};Initial Catalog={DbTest};Server={Ip}";
        
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