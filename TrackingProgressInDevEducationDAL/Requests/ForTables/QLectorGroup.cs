using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QLectorGroup : IQuery
    {
        public Type Type { get; } = typeof(LectorGroup);
        public string Name { get; set; }
        public string Params { get; set; }
        public QLectorGroup NullifyLectorGroup()
        {
            Name = nameof(NullifyLectorGroup);
            Params = string.Empty;
            return this;
        }
    }
}