using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using TrackingProgressInDevEducationDAL.Models;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;

namespace TrackingProgressInDevEducationDAL.Senders
{
    public class Setter : ASender
    {
        public AbstractModel Single(IQuery query)
        {
            Connection connection = new();
            using (IDbConnection dbConnection = connection.Connect())
            {
                MethodInfo method = typeof(Repositories.Setter).GetMethod(nameof(Repositories.Setter.Single));
                return ReflectionSingle(query, dbConnection, method);
            }
        }

        public IEnumerable<AbstractModel> Several(IQuery query)
        {
            Connection connection = new();
            using (IDbConnection dbConnection = connection.Connect())
            {
                MethodInfo method = typeof(Repositories.Setter).GetMethod(nameof(Repositories.Setter.Several));
                return ReflectionSeveral(query, dbConnection, method);
            }
        }
    }
}