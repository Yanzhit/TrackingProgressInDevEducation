using System.Data;
using System.Reflection;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;

namespace TrackingProgressInDevEducationDAL.Senders
{
    public class Update : ASender
    {
        public object Upd(IQuery query)
        {
            Connection connection = new();
            using (IDbConnection dbConnection = connection.Connect())
            {
                MethodInfo method = typeof(Repositories.Update).GetMethod(nameof(Repositories.Update.Single));
                return Reflection(query, dbConnection, method);
            }
        }
    }
}