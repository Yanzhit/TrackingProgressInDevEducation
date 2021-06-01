using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QLectorGroup : IQuery
    {
        public Type Type { get; } = typeof(LectorGroup);
        public TypeQueries TypeQueries { get; set; }
        public string Name { get; set; }
        public string Params { get; set; }
        public QLectorGroup NullifyLectorGroup()
        {
            TypeQueries = TypeQueries.Nullify;
            Name = nameof(NullifyLectorGroup);
            Params = string.Empty;
            return this;
        }
    }
}