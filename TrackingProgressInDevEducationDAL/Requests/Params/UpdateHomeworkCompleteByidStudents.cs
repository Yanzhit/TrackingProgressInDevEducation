using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.Params
{
    public class UpdateHomeworkCompleteByIdStudents : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public UpdateHomeworkCompleteByIdStudents(int studentId, bool status)
        {
            Type = typeof(HomeworkComplete);
            Name = "UpdateHomeworkCompleteByIdStudents";
            Params = $"{studentId}, {status}";
        }
    }
}
