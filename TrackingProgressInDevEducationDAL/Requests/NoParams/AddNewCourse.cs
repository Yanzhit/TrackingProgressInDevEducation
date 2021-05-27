using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;


namespace TrackingProgressInDevEducationDAL.Requests.NoParams
{
    public class AddNewCourse :IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public AddNewCourse( string Name, DateTime StartedOn, DateTime FinishedOn)
        {
            Type = typeof(Courses);
            Name = "AddNewCourse";
            Params = $"{Name},{StartedOn},{FinishedOn}";
        }
    }
}
