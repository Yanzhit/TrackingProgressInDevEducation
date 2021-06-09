using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Facades;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Models.Facades
{
    public class Courses : AFacade
    {
        private readonly  QCourse  _query  = new();

        /// <summary>
        /// Создать новый Курс
        /// </summary>
        /// <param name="course">Объект данных</param>
        /// <returns>Курс</returns>
        public Course SetNewCourse(Course course)
        {
            return (Course)Manager.Setter.Single(_query.SetNewCourse(course));
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return (IEnumerable<Course>)Manager.Getter.Several(_query.GetAllCourses());
        }

        /// <summary>
        /// Обнуление таблицы Курсов и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Course> NullifyCourses()
        {
            return (IEnumerable<Course>)Manager.Remove.Rem(_query.NullifyCourses());
        }
    }
}