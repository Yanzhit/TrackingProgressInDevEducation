using System.Data;
using System.Reflection;
using TrackingProgressInDevEducationDAL.Abstracts;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;

namespace TrackingProgressInDevEducationDAL.Senders
{
    public class Remove : ASender
    {
        public object Rem(IQuery query)
        {
            Connection connection = new();
            using (IDbConnection dbConnection = connection.Connect())
            {
                MethodInfo method = typeof(Repositories.Remove).GetMethod(nameof(Repositories.Remove.SeveralAsync));
                return Refraction(query, dbConnection, method);
            }
        }
    }
}