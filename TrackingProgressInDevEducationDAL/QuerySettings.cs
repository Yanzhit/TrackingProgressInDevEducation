using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Threading.Tasks;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL
{
    public static class QuerySettings
    {
        public static object QuerySet(IQuery query)
        {
            Connection.Connect();
            MethodInfo method = null;
            switch (query.TypeQueries)
            {
                case TypeQueries.GetOne:
                    method = typeof(Repository).GetMethod(nameof(Repository.GetOneAsync));
                    break;
                case TypeQueries.SetOne:
                    method = typeof(Repository).GetMethod(nameof(Repository.SetOneAsync));
                    break;
                case TypeQueries.UpdateOne:
                    method = typeof(Repository).GetMethod(nameof(Repository.UpdateOneAsync));
                    break;
                case TypeQueries.RemoveOne:
                    method = typeof(Repository).GetMethod(nameof(Repository.RemoveOneAsync));
                    break;
                case TypeQueries.GetSeveral:
                    method = typeof(Repository).GetMethod(nameof(Repository.GetSeveralAsync));
                    break;
                case TypeQueries.SetSeveral:
                    method = typeof(Repository).GetMethod(nameof(Repository.SetSeveralAsync));
                    break;
                case TypeQueries.UpdateSeveral:
                    method = typeof(Repository).GetMethod(nameof(Repository.UpdateSeveralAsync));
                    break;
                case TypeQueries.RemoveSeveral:
                    method = typeof(Repository).GetMethod(nameof(Repository.RemoveSeveralAsync));
                    break;
                case TypeQueries.Nullify:
                    method = typeof(Repository).GetMethod(nameof(Repository.NullifyAsync));
                    break;
            }
            MethodInfo generic = method.MakeGenericMethod(query.Type);
            object objects = generic.Invoke(null, new object[] {query});
            Connection.Disconnect();
            return objects;
        }
    }
}