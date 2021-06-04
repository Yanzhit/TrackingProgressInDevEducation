using System.Collections.Generic;
using System.Data;
using System.Reflection;
using TrackingProgressInDevEducationDAL.Models;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;

namespace TrackingProgressInDevEducationDAL.Senders
{
    public class Update : ASender
    {
        public IEnumerable<AbstractModel> Upd(IQuery query)
        {
            Connection connection = new();
            using (IDbConnection dbConnection = connection.Connect())
            {
                MethodInfo method = typeof(Repositories.Update).GetMethod(nameof(Repositories.Update.Several));
                return ReflectionSeveral(query, dbConnection, method);
            }
        }
    }
}