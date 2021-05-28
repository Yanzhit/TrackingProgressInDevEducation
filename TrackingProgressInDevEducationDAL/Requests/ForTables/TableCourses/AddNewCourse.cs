using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables.TableCourses
{
    public class AddNewCourse : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public AddNewCourse(string name, DateTime startedOn, DateTime finishedOn)
        {
            Type = typeof(Courses);
            Name = GetType().Name;
            Params = $"{name}, {startedOn}, {finishedOn}";
        }
    }
}
