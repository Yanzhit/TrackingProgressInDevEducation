using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QTeamStudent : IQuery
    {
        public Type Type { get; } = typeof(TeamStudent);
        public string Name { get; set; }
        public string Params { get; set; }

        public QTeamStudent NullifyTeamStudent()
        {
            Name = nameof(NullifyTeamStudent);
            Params = string.Empty;
            return this;
        }
    }
}