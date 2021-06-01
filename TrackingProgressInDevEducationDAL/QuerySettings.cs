using System.Data;
using System.Reflection;using TrackingProgressInDevEducationDAL;
using TrackingProgressInDevEducationDAL.Interfaces;
using TrackingProgressInDevEducationDAL.Repositories;
using static TrackingProgressInDevEducationDAL.Defines;

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
            string command = ConfigCommand(query);
            object objects = generic.Invoke(this, new object[] {dbConnection, command});
            connection.Disconnect(dbConnection); //нужно ли прокидывать? или можно тут отрубать
            return objects;
        }

        private MethodInfo SelectMetod(TypeQueries type)
        {
            return type switch
            {
                TypeQueries.Single => typeof(Repository).GetMethod(nameof(Repository.SingleAsync)),
                TypeQueries.Several => typeof(Repository).GetMethod(nameof(Repository.SeveralAsync)),
                TypeQueries.Nullify => typeof(Repository).GetMethod(nameof(Repository.NullifyAsync)),
                _ => null
            };
        }

        private string ConfigCommand(IQuery query)
        {
            return $"{Exec}{Gap}{Schema}{Point}{query.Name}{Gap}{query.Params}";
        }
    }
}