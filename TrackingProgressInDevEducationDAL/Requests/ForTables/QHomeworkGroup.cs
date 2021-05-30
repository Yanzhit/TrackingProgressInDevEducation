using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QHomeworkGroup : IQuery
    {
        public Type Type { get; } = typeof(HomeworkGroup);
        public string Schema { get; set; } = $"exec TrackingProgressInDevEducationDB.";
        public TypeQueries TypeQueries { get; set; }
        public string Name { get; set; }
        public string Params { get; set; }

        public QHomeworkGroup NullifyHomeworkGroup()
        {
            TypeQueries = TypeQueries.Nullify;
            Name = nameof(NullifyHomeworkGroup);
            Params = string.Empty;
            return this;
        }
    }
}