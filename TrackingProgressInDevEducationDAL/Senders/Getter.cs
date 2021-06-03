using System.Data;
using System.Reflection;
using TrackingProgressInDevEducationDAL.Abstracts;
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
                string command = ConfigCommand(query);
                MethodInfo method = typeof(Repositories.Getter).GetMethod(nameof(Repositories.Getter.SingleAsync));
                MethodInfo generic = method.MakeGenericMethod(query.Type);
                object obj = generic.Invoke(this, new object[] {dbConnection, command});
                Disconnect(dbConnection);
                return obj;
            }
        }

        public object Several(IQuery query)
        {
            Connection connection = new();
            using (IDbConnection dbConnection = connection.Connect())
            {
                string command = ConfigCommand(query);
                MethodInfo method = typeof(Repositories.Getter).GetMethod(nameof(Repositories.Getter.SeveralAsync));
                MethodInfo generic = method.MakeGenericMethod(query.Type);
                object obj = generic.Invoke(this, new object[] {dbConnection, command});
                Disconnect(dbConnection);
                return obj;
            }
        }
    }
}