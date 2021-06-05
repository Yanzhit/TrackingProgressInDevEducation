using System.Collections.Generic;
using System.Data;
using System.Reflection;
using TrackingProgressInDevEducationDAL.Models;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;

namespace TrackingProgressInDevEducationDAL.Senders
{
    public class Getter : ASender
    {
        public AbstractModel Single(IQuery query)
        {
            Connection connection = new();
            using (IDbConnection dbConnection = connection.Connect())
            {
                MethodInfo method = typeof(Repositories.Getter).GetMethod(nameof(Repositories.Getter.Single));
                return ReflectionSingle(query, dbConnection, method);
            }
        }

        public IEnumerable<AbstractModel> Several(IQuery query)
        {
            Connection connection = new();
            using (IDbConnection dbConnection = connection.Connect())
            {
                MethodInfo method = typeof(Repositories.Getter).GetMethod(nameof(Repositories.Getter.Several));
                return ReflectionSeveral(query, dbConnection, method);
            }
        }
    }
}