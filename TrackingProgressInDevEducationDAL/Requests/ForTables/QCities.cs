using System;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QCities : IQuery
    {
        public Type Type { get; }
        public string Name { get; set; }
        public string Params { get; set; }
    }
}