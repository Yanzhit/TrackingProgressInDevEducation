using System;
using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Courses : AFacade
    {
        private readonly  QCourse  _query  = new();

        /// <summary>
        /// Создать новый Курс
        /// </summary>
        /// <param name="course">Объект данных</param>
        /// <returns>Курс</returns>
        public AResult SetNewCourse(Course course)
        {
            return (AResult)Manager.Setter.Single(_query.SetNewCourse(course));
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return (IEnumerable<Course>)Manager.Getter.Several(_query.GetAllCourses());
        }

        /// <summary>
        /// Обнуление таблицы Курсов и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AResult> NullifyCourses()
        {
            return (IEnumerable<AResult>)Manager.Remove.Rem(_query.NullifyCourses());
        }
    }
}