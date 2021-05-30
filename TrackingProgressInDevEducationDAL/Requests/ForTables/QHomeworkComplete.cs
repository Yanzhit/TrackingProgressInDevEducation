using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QHomeworkComplete : IQuery
    {
        public Type Type { get; } = typeof(HomeworkComplete);
        public string Schema { get; set; } = $"exec TrackingProgressInDevEducationDB.";
        public TypeQueries TypeQueries { get; set; }
        public string Name { get; set; }
        public string Params { get; set; }

        public QHomeworkComplete UpdateHWCompleteByIdHW(int homeworkId, bool status)
        {
            TypeQueries = TypeQueries.UpdateOne;
            Name = nameof(UpdateHWCompleteByIdHW);
            Params = $"{homeworkId}, {status}";
            return this;
        }
        public QHomeworkComplete UpdateHWCompleteByIdStudents(int studentId, bool status)
        {
            TypeQueries = TypeQueries.UpdateOne;
            Name = nameof(UpdateHWCompleteByIdStudents);
            Params = $"{studentId}, {status}";
            return this;
        }
        public QHomeworkComplete NullifyHWComplete()
        {
            TypeQueries = TypeQueries.Nullify;
            Name = nameof(NullifyHWComplete);
            Params = string.Empty;
            return this;
        }
    }
}