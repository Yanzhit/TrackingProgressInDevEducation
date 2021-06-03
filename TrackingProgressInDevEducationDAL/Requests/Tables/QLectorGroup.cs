using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;
using static TrackingProgressInDevEducationDAL.Defines;

namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    public class QLectorGroup : IQuery
    {
        public Type Type { get; } = typeof(LectorGroup);
        public string Name { get; set; }
        public string Params { get; set; }

        public QLectorGroup SetNewLectorGroup(int lectorId, int groupId)
        {
            Name = nameof(SetNewLectorGroup);
            Params = $"{lectorId}{Sep}{groupId}";
            return this;
        }

        public QLectorGroup NullifyLectorGroup()
        {
            Name = nameof(NullifyLectorGroup);
            Params = string.Empty;
            return this;
        }
    }
}