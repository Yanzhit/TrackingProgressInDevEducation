using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;


namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
    public class AddNewCourse :IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Command { get; }

        public AddNewCourse()
        {
            Type = typeof(Courses);
            Name = "AddNewCourse";
            Command = "";
        }
    }
}
