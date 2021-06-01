using System.Data;
using System.Data.SqlClient;
using static TrackingProgressInDevEducationDAL.Defines;

namespace TrackingProgressInDevEducationDAL
{
    public class Connection
    {
        private readonly string _cs =
            $@"Persist Security Info={F};User ID={User};Password={Password};Initial Catalog={DbTest};Server={Ip}";
        
        public IDbConnection Connect()
        {
            return new SqlConnection(_cs);
        }
    }
}