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
                MethodInfo method = typeof(Repositories.Nullify).GetMethod(nameof(Repositories.Nullify.Single));
                return Refraction(query, dbConnection, method);
            }
        }
    }
}