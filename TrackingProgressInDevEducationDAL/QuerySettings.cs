using System.Data;
using System.Reflection;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL
{
    public class QuerySettings
    {
        
        public object QuerySet(IQuery query)
        {
            Connection connection = new();
            IDbConnection dbConnection = connection.Connect();
            MethodInfo method = SelectMetod(query.TypeQueries);
            MethodInfo generic = method.MakeGenericMethod(query.Type);
            object objects = generic.Invoke(this, new object[] {query, dbConnection});
            connection.Disconnect(dbConnection); //нужно ли прокидывать? или можно тут отрубать
            return objects;
        }

        private MethodInfo SelectMetod(TypeQueries type)
        {
            switch (type)
            {
                case TypeQueries.GetOne:
                    return typeof(Repository).GetMethod(nameof(Repository.GetOneAsync));
                case TypeQueries.SetOne:
                    return typeof(Repository).GetMethod(nameof(Repository.SetOneAsync));
                case TypeQueries.UpdateOne:
                    return typeof(Repository).GetMethod(nameof(Repository.UpdateOneAsync));
                case TypeQueries.RemoveOne:
                    return typeof(Repository).GetMethod(nameof(Repository.RemoveOneAsync));
                case TypeQueries.GetSeveral:
                    return typeof(Repository).GetMethod(nameof(Repository.GetSeveralAsync));
                case TypeQueries.SetSeveral:
                    return typeof(Repository).GetMethod(nameof(Repository.SetSeveralAsync));
                case TypeQueries.UpdateSeveral:
                    return typeof(Repository).GetMethod(nameof(Repository.UpdateSeveralAsync));
                case TypeQueries.RemoveSeveral:
                    return typeof(Repository).GetMethod(nameof(Repository.RemoveSeveralAsync));
                case TypeQueries.Nullify:
                    return typeof(Repository).GetMethod(nameof(Repository.NullifyAsync));
            }
            return null;
        }
    }
}