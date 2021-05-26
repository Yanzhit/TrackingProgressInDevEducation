using System;
using System.Collections.Generic;
using System.Reflection;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Interface;

namespace TrackingProgressInDevEducationDAL
{
    public class QuerySettings
    {
        public static List<IModels> Models { get; set; } = new List<IModels>();

        public void Connect(Query query)
        {
            MethodInfo method = typeof(Connection).GetMethod(nameof(Connection.Connect));
            MethodInfo generic = method.MakeGenericMethod(query.Type);

            var result = generic.Invoke(null, new object[] {query.QueryName});
            Models.AddRange((List<IModels>) result);
        }
    }
}