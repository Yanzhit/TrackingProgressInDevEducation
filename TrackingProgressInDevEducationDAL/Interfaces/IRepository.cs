using System.Data;

namespace TrackingProgressInDevEducationDAL.Interfaces
{
    public interface IRepository
    {
        object Async(IDbConnection connection, string command);
    }
}