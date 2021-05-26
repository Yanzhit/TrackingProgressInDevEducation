using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
    public class UpdateHomeworkCompleteByidHomework:IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Command { get; }

        public UpdateHomeworkCompleteByidHomework()
        {
            Type = typeof(HomeworkComplete);
            Name = "UpdateHomeworkCompleteByidHomework";
            Command = "";
        }
    }
}
