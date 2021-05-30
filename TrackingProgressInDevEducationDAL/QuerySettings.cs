using System.Collections.Generic;
using System.Data;
using System.Reflection;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL
{
    public static class QuerySettings
    {
        public static object QuerySet(IQuery query)
        {
            IDbConnection dbConnection = Connection.Connect();
            Repository repository = new Repository(dbConnection);
            MethodInfo method = null;
            switch (query.TypeQueries)
            {
                case TypeQueries.Get:
                    method = typeof(Repository).GetMethod(nameof(Repository.GetAsync));
                    break;
                case TypeQueries.Set:
                    method = typeof(Repository).GetMethod(nameof(Repository.SetAsync));
                    break;
                case TypeQueries.Update:
                    method = typeof(Repository).GetMethod(nameof(Repository.UpdateAsync));
                    break;
                case TypeQueries.Remove:
                    method = typeof(Repository).GetMethod(nameof(Repository.RemoveAsync));
                    break;
                case TypeQueries.Nullify:
                    method = typeof(Repository).GetMethod(nameof(Repository.NullifyAsync));
                    break;
            }
            MethodInfo generic = method.MakeGenericMethod(query.Type);
            return generic.Invoke(null, new object[] {query});
        }
    }
}