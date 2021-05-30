using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QCourse : IQuery
    {
        public Type Type { get; } = typeof(Course);
        public TypeQueries TypeQueries { get; set; }
        public string Name { get; set; }
        public string Params { get; set; }

        public QCourse AddNewCourse(string name, DateTime startedOn, DateTime finishedOn)
        {
            TypeQueries = TypeQueries.Set;
            Name = nameof(AddNewCourse);
            Params = $"{name}, {startedOn}, {finishedOn}";
            return this;
        }
        public QCourse GetAllCourses()
        {
            TypeQueries = TypeQueries.Get;
            Name = nameof(GetAllCourses);
            Params = string.Empty;
            return this;
        }
        public QCourse RemoveCourseById(int id)
        {
            TypeQueries = TypeQueries.Remove;
            Name = nameof(RemoveCourseById);
            Params = $"{id}";
            return this;
        }
        public QCourse NullifyCourses()
        {
            TypeQueries = TypeQueries.Remove;
            Name = nameof(NullifyCourses);
            Params = string.Empty;
            return this;
        }
    }
}