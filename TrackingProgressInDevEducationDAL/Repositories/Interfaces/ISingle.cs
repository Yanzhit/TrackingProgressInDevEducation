using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace TrackingProgressInDevEducationDAL.Repositories.Interfaces
{
    public interface ISingle
    {
        static Task<T> SingleAsync<T>(IDbConnection connection, string command)
        {
            throw new System.NotImplementedException();
        }
    }
}