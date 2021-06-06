using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using static TrackingProgressInDevEducationDAL.Defines;

namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    public class QLectorCourse : IQuery
    {
        public Type QueryType { get; set; }
        public Type ModelType { get; } = typeof(LectorCourse);
        public string Name { get; set; }
        public string Params { get; set; }

        public QLectorCourse SetNewLectorCourse(LectorCourse lCourse)
        {
            QueryType = typeof(Setter);
            Name = nameof(SetNewLectorCourse);
            Params = $"{SepStr}{lCourse.LectorId}{SepMid}{lCourse.CourseId}{SepEnd}";
            return this;
        }

        public QLectorCourse NullifyCourse()
        {
            QueryType = typeof(Remove);
            Name = nameof(NullifyCourse);
            Params = string.Empty;
            return this;
        }
    }
}