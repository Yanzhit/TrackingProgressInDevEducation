using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables.TableCourses
{
    public class RemoveCourseById : IQuery
    {
        public Type Type { get; }
        public string Name { get; }
        public string Params { get; }

        public RemoveCourseById(int id)
        {
            Type = typeof(Courses);
            Name = GetType().Name;
            Params = $"{id}";
        }
    }
}
