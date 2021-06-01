using System;
using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.ForTables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Courses
    {
        private readonly QCourse _qCourse = new();
        private readonly QuerySettings _query = new();

        /// <summary>
        /// Создать новый Курс
        /// </summary>
        /// <param name="name">Имя курса</param>
        /// <returns>Курс</returns>
        public Course SetNewCourse(string name, DateTime startedOn, DateTime finishedOn)
        {
            return (Course)_query.QuerySet(_qCourse.SetNewCourse(name, startedOn, finishedOn));
        }

        /// <summary>
        /// Обнуление таблицы Курсов и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Course> NullifyCourses()
        {
            return (IEnumerable<Course>)_query.QuerySet(_qCourse.NullifyCourses());
        }
    }
}