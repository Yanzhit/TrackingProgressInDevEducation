using System;
using TrackingProgressInDevEducationDAL.Interfaces;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    public class QLectorCourse : IQuery
    {
        public Type Type { get; } = typeof(LectorCourse);
        public TypeQueries TypeQueries { get; set; }
        public string Name { get; set; }
        public string Params { get; set; }

        public QLectorCourse NullifyCourse()
        {
            TypeQueries = TypeQueries.Nullify;
            Name = nameof(NullifyCourse);
            Params = string.Empty;
            return this;
        }
    }
}