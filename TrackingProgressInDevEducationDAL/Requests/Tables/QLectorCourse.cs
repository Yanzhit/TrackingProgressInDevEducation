using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;
using static TrackingProgressInDevEducationDAL.Defines;

namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    public class QLectorCourse : IQuery
    {
        public Type Type { get; set; } = typeof(AResult);
        public Type Test { get; } = typeof(LectorCourse);
        public string Name { get; set; }
        public string Params { get; set; }

        public QLectorCourse SetNewLectorCourse(int lectorId, int courseId)
        {
            Name = nameof(SetNewLectorCourse);
            Params = $"{lectorId}{Sep}{courseId}";
            return this;
        }

        public QLectorCourse NullifyCourse()
        {
            Name = nameof(NullifyCourse);
            Params = string.Empty;
            return this;
        }
    }
}