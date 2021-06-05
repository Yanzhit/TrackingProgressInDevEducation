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
        /// <param name="name">Имя курса</param>
        /// <param name="startedOn">Дата начала курса</param>
        /// <param name="finishedOn">Дата окончания курса</param>
        /// <returns>Курс</returns>
        public AResult SetNewCourse(string name, DateTime startedOn, DateTime finishedOn)
        {
            return (AResult)Manager.Setter.Single(_query.SetNewCourse(name, startedOn, finishedOn));
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