using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;
using static TrackingProgressInDevEducationDAL.Defines;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QHomeworkComplete : IQuery
    {
        public Type Type { get; } = typeof(HomeworkComplete);
        public TypeQueries TypeQueries { get; set; }
        public string Name { get; set; }
        public string Params { get; set; }

        public QHomeworkComplete UpdateHWCompleteByIdHW(int homeworkId, bool status)
        {
            TypeQueries = TypeQueries.UpdateOne;
            Name = nameof(UpdateHWCompleteByIdHW);
            Params = $"{homeworkId}{Sep}{status}";
            return this;
        }
        public QHomeworkComplete UpdateHWCompleteByIdStudents(int studentId, bool status)
        {
            TypeQueries = TypeQueries.UpdateOne;
            Name = nameof(UpdateHWCompleteByIdStudents);
            Params = $"{studentId}{Sep}{status}";
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