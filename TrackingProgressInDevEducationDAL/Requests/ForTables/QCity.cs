using System;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QCity : IQuery
    {
        public Type Type { get; } // = typeof(City);
        public TypeQueries TypeQueries { get; set; }
        public string Name { get; set; }
        public string Params { get; set; }

        public QCity NullifyCities()
        {
            TypeQueries = TypeQueries.Remove;
            Name = nameof(NullifyCities);
            Params = string.Empty;
            return this;
        }
    }
}