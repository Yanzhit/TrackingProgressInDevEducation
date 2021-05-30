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

        public QHomeworkComplete UpdateHomeworkCompleteByIdHomework(int homeworkId, bool status)
        {
            TypeQueries = TypeQueries.Update;
            Name = nameof(UpdateHomeworkCompleteByIdHomework);
            Params = $"{homeworkId}, {status}";
            return this;
        }
        public QHomeworkComplete UpdateHomeworkCompleteByIdStudents(int studentId, bool status)
        {
            TypeQueries = TypeQueries.Update;
            Name = nameof(UpdateHomeworkCompleteByIdStudents);
            Params = $"{studentId}, {status}";
            return this;
        }
        public QHomeworkComplete NullifyHomeworkComplete()
        {
            TypeQueries = TypeQueries.Nullify;
            Name = nameof(NullifyHomeworkComplete);
            Params = string.Empty;
            return this;
        }
    }
}