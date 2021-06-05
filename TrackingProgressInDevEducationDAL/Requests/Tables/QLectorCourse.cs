using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;
using static TrackingProgressInDevEducationDAL.Defines;

namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    public class QLectorCourse : IQuery
    {
        public Type QueryType { get; set; }
        public Type ModelType { get; } = typeof(LectorCourse);
        public string Name { get; set; }
        public string Params { get; set; }

        public QLectorCourse SetNewLectorCourse(int lectorId, int courseId)
        {
            QueryType = typeof(Setter);
            Name = nameof(SetNewLectorCourse);
            Params = $"{SepStr}{lectorId}{SepMid}{courseId}{SepEnd}";
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