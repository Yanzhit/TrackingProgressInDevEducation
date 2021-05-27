using System.Reflection;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Interface;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL
{
    public class QuerySettings
    {
        public static object QuerySet(IQuery query)
        {
            MethodInfo method = typeof(Connection).GetMethod(nameof(Connection.Connect));
            MethodInfo generic = method.MakeGenericMethod(query.Type);
            return generic.Invoke(null, new object[] {query});
        }


        public override bool Equals(object obj)
        {
            switch (obj)
            {
                //case is Students:

            }


            return true;
        }

        public override string ToString()
        {
            return "";
        }
    }
}