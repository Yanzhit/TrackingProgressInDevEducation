using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using static TrackingProgressInDevEducationDAL.Defines;

namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    public class QLectorGroup : IQuery
    {
        public Type QueryType { get; set; }
        public Type ModelType { get; } = typeof(LectorGroup);
        public string Name { get; set; }
        public string Params { get; set; }

        public QLectorGroup SetNewLectorGroup(LectorGroup lGroup)
        {
            QueryType = typeof(Setter);
            Name = nameof(SetNewLectorGroup);
            Params = $"{SepStr}{lGroup.LectorId}{SepMid}{lGroup.GroupId}{SepEnd}";
            return this;
        }

        public QLectorGroup NullifyLectorGroup()
        {
            QueryType = typeof(Remove);
            Name = nameof(NullifyLectorGroup);
            Params = string.Empty;
            return this;
        }
    }
}