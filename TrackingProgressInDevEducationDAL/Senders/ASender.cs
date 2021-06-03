using System.Collections;
using System.Data;
using System.Reflection;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;
using static TrackingProgressInDevEducationDAL.Defines;

namespace TrackingProgressInDevEducationDAL.Senders
{
    public abstract class ASender
    {
        
        protected object Refraction(IQuery query, IDbConnection dbConnection, MethodInfo method)
        {
            string command = ConfigCommand(query);
            MethodInfo generic = method.MakeGenericMethod(query.Type);
            object obj = generic.Invoke(null, new object[] {dbConnection, command});
            return obj;
        }

        private string ConfigCommand(IQuery query)
        {
            return $"{Exec}{Gap}{Schema}{Point}{query.Name}{Gap}{query.Params}";
        }
    }
}