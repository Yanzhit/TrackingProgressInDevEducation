using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
    public class UpdateHomeworkCompleteByidStudents:IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Command { get; }

        public UpdateHomeworkCompleteByidStudents()
        {
            Type = typeof(HomeworkComplete);
            Name = "UpdateHomeworkCompleteByidStudents";
            Command = "";
        }
    }
}
