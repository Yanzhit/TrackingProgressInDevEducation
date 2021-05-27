using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
    public class UpdateHomeworkCompleteByIdHomework : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public UpdateHomeworkCompleteByIdHomework(int homeworkId, bool status)
        {
            Type = typeof(HomeworkComplete);
            Name = "UpdateHomeworkCompleteByIdHomework";
            Params = $"{homeworkId}, {status}";
        }
    }
}
