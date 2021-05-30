using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QTeamStudent : IQuery
    {
        public Type Type { get; } = typeof(TeamStudent);
        public string Schema { get; set; } = $"exec TrackingProgressInDevEducationDB.";
        public TypeQueries TypeQueries { get; set; }
        public string Name { get; set; }
        public string Params { get; set; }

        public QTeamStudent NullifyTeamStudent()
        {
            TypeQueries = TypeQueries.Nullify;
            Name = nameof(NullifyTeamStudent);
            Params = string.Empty;
            return this;
        }
    }
}