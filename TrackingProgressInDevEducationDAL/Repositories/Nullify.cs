using System.Data;
using TrackingProgressInDevEducationDAL.Interfaces;

namespace TrackingProgressInDevEducationDAL.Repositories
{
    public class Nullify : IRepository
    {
        public object Async(IDbConnection connection, string command)
        {
            throw new System.NotImplementedException();
        }
    }
}