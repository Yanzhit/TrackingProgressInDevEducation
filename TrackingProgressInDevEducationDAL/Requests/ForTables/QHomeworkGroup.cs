using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QHomeworkGroup : IQuery
    {
        public Type Type { get; } = typeof(HomeworkGroup);
        public TypeQueries TypeQueries { get; set; }
        public string Name { get; set; }
        public string Params { get; set; }

        public QHomeworkGroup NulliHomeworkGroup()
        {
            TypeQueries = TypeQueries.Remove;
            Name = nameof(NulliHomeworkGroup);
            Params = string.Empty;
            return this;
        }
    }
}