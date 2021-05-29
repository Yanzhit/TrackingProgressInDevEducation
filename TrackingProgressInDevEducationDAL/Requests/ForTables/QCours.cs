using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interface;

namespace TrackingProgressInDevEducationDAL.Requests.ForTables
{
    public class QCours : IQuery
    {
        public Type Type { get; } = typeof(Course);
        public string Name { get; set; }
        public string Params { get; set; }

        public QCours AddNewCourse(string name, DateTime startedOn, DateTime finishedOn)
        {
            Name = nameof(AddNewCourse);
            Params = $"{name}, {startedOn}, {finishedOn}";
            return this;
        }
        public QCours GetAllCourses()
        {
            Name = nameof(GetAllCourses);
            Params = string.Empty;
            return this;
        }
        public QCours RemoveCourseById(int id)
        {
            Name = nameof(RemoveCourseById);
            Params = $"{id}";
            return this;
        }
        public QCours NullifyCourses()
        {
            Name = nameof(NullifyCourses);
            Params = string.Empty;
            return this;
        }
    }
}