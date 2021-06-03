using System.Data;
using System.Reflection;
using TrackingProgressInDevEducationDAL.Abstracts;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;

namespace TrackingProgressInDevEducationDAL.Senders
{
    public class Nullify : ASender
    {
        public object Null(IQuery query)
        {
            Connection connection = new();
            using (IDbConnection dbConnection = connection.Connect())
            {
                string command = ConfigCommand(query);
                MethodInfo method = typeof(Repositories.Nullify).GetMethod(nameof(Repositories.Nullify.SeveralAsync));
                MethodInfo generic = method.MakeGenericMethod(query.Type);
                object obj = generic.Invoke(this, new object[] {dbConnection, command});
                Disconnect(dbConnection);
                return obj;
            }
        }
    }
}