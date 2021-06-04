using System.Data;
using System.Reflection;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;

namespace TrackingProgressInDevEducationDAL.Senders
{
    public class Getter : ASender
    {
        public object Single(IQuery query)
        {
            Connection connection = new();
            using (IDbConnection dbConnection = connection.Connect())
            {
                MethodInfo method = typeof(Repositories.Getter).GetMethod(nameof(Repositories.Getter.Single));
                return Reflection(query, dbConnection, method);
            }
        }

        public object Several(IQuery query)
        {
            Connection connection = new();
            using (IDbConnection dbConnection = connection.Connect())
            {
                MethodInfo method = typeof(Repositories.Getter).GetMethod(nameof(Repositories.Getter.Several));
                return Reflection(query, dbConnection, method);
            }
        }
    }
}