using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
    public class UpdateHomeworkCompleteByidStudents:IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public UpdateHomeworkCompleteByidStudents(int Studentid, bool Status)
        {
            Type = typeof(HomeworkComplete);
            Name = "UpdateHomeworkCompleteByidStudents";
            Params = $"{Studentid},{Status}";
        }
    }
}
