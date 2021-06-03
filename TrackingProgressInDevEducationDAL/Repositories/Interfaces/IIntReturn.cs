using System.Data;
using System.Threading.Tasks;

namespace TrackingProgressInDevEducationDAL.Repositories.Interfaces
{
    public interface IIntReturn
    {
        Task<int> IntReturnAsync<T>(IDbConnection connection, string command);
    }
}