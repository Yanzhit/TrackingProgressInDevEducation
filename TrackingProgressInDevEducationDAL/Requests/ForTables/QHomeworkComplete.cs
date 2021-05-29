using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QHomeworkComplete : IQuery
    {
        public Type Type { get; } = typeof(HomeworkComplete);
        public string Name { get; set; }
        public string Params { get; set; }

        public QHomeworkComplete UpdateHomeworkCompleteByIdHomework(int homeworkId, bool status)
        {
            Name = nameof(UpdateHomeworkCompleteByIdHomework);
            Params = $"{homeworkId}, {status}";
            return this;
        }
        public QHomeworkComplete UpdateHomeworkCompleteByIdStudents(int studentId, bool status)
        {
            Name = nameof(UpdateHomeworkCompleteByIdStudents);
            Params = $"{studentId}, {status}";
            return this;
        }
        public QHomeworkComplete NullifyHomeworkComplete()
        {
            Name = nameof(NullifyHomeworkComplete);
            Params = string.Empty;
            return this;
        }
    }
}