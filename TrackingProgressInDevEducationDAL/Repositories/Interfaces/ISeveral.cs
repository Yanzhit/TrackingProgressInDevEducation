using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace TrackingProgressInDevEducationDAL.Repositories.Interfaces
{
    public interface ISeveral
    {
        Task<IEnumerable<T>> SeveralAsync<T>(IDbConnection connection, string command);
    }
}