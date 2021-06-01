using System.Data;
using TrackingProgressInDevEducationDAL.Interfaces;

namespace TrackingProgressInDevEducationDAL.Repositories
{
    public class Single : IRepository
    {
        public object Async(IDbConnection connection, string command)
        {
            throw new System.NotImplementedException();
        }
    }
}