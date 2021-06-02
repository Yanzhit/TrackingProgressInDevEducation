using System;
using TrackingProgressInDevEducationDAL.Interfaces;
using TrackingProgressInDevEducationDAL.Models.Bases;
using static TrackingProgressInDevEducationDAL.Defines;

namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    public class QLectorGroup : IQuery
    {
        public Type Type { get; } = typeof(LectorGroup);
        public TypeQueries TypeQueries { get; set; }
        public string Name { get; set; }
        public string Params { get; set; }

        public QLectorGroup SetNewLectorGroup(int lectorId, int groupId)
        {
            TypeQueries = TypeQueries.Single;
            Name = nameof(SetNewLectorGroup);
            Params = $"{lectorId}{Sep}{groupId}";
            return this;
        }

        public QLectorGroup NullifyLectorGroup()
        {
            TypeQueries = TypeQueries.Nullify;
            Name = nameof(NullifyLectorGroup);
            Params = string.Empty;
            return this;
        }
    }
}