using System.Data;
using System.Threading.Tasks;

namespace TrackingProgressInDevEducationDAL.Repositories.Interfaces
{
    public interface ISingle
    {
        Task<T> SingleAsync<T>(IDbConnection connection, string command);
    }
}