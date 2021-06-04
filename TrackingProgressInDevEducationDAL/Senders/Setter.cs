using System.Data;
using System.Reflection;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;

namespace TrackingProgressInDevEducationDAL.Senders
{
    public class Setter : ASender
    {
        public object Single(IQuery query)
        {
            Connection connection = new();
            using (IDbConnection dbConnection = connection.Connect())
            {
                MethodInfo method = typeof(Repositories.Setter).GetMethod(nameof(Repositories.Setter.Single));
                return Reflection(query, dbConnection, method);
            }
        }

        public object Several(IQuery query)
        {
            Connection connection = new();
            using (IDbConnection dbConnection = connection.Connect())
            {
                MethodInfo method = typeof(Repositories.Setter).GetMethod(nameof(Repositories.Setter.Several));
                return Reflection(query, dbConnection, method);
            }
        }
    }
}