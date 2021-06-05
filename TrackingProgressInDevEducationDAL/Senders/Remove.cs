using System.Collections.Generic;
using System.Data;
using System.Reflection;
using TrackingProgressInDevEducationDAL.Models;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;

namespace TrackingProgressInDevEducationDAL.Senders
{
    public class Remove : ASender
    {
        public IEnumerable<AbstractModel> Rem(IQuery query)
        {
            Connection connection = new();
            using (IDbConnection dbConnection = connection.Connect())
            {
                MethodInfo method = typeof(Repositories.Remove).GetMethod(nameof(Repositories.Remove.Several));
                return ReflectionSeveral(query, dbConnection, method);
            }
        }
    }
}