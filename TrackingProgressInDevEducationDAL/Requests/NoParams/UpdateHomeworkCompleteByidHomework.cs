using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
    public class UpdateHomeworkCompleteByidHomework:IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public UpdateHomeworkCompleteByidHomework(int HomeworkId, bool Status)
        {
            Type = typeof(HomeworkComplete);
            Name = "UpdateHomeworkCompleteByidHomework";
            Params = $"{HomeworkId},{Status}";
        }
    }
}
