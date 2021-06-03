using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;
using static TrackingProgressInDevEducationDAL.Defines;

namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    public class QLectorCourse : IQuery
    {
        public Type Type { get; set; }
        public Type Test { get; } = typeof(LectorCourse);
        public string Name { get; set; }
        public string Params { get; set; }

        public QLectorCourse SetNewLectorCourse(int lectorId, int courseId)
        {
            Type = typeof(Setter);
            Name = nameof(SetNewLectorCourse);
            Params = $"{lectorId}{Sep}{courseId}";
            return this;
        }

        public QLectorCourse NullifyCourse()
        {
            Type = typeof(Remove);
            Name = nameof(NullifyCourse);
            Params = string.Empty;
            return this;
        }
    }
}