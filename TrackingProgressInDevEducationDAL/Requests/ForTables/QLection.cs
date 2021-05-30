using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QLection : IQuery
    {
        public Type Type { get; } = typeof(Lection);
        public TypeQueries TypeQueries { get; set; }
        public string Name { get; set; }
        public string Params { get; set; }

        public QLection NullifyLections()
        {
            TypeQueries = TypeQueries.Remove;
            Name = nameof(NullifyLections);
            Params = string.Empty;
            return this;
        }
    }
}