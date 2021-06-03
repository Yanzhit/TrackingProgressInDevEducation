using System;
using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Abstracts;
using TrackingProgressInDevEducationDAL.Models.Bases;
﻿using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Courses : AFacade
    {
        public QCourse Query { get; init; }

        /// <summary>
        /// Создать новый Курс
        /// </summary>
        /// <param name="name">Имя курса</param>
        /// <param name="startedOn">Дата начала курса</param>
        /// <param name="finishedOn">Дата окончания курса</param>
        /// <returns>Курс</returns>
        public Course SetNewCourse(string name, DateTime startedOn, DateTime finishedOn)
        {
            return (Course)Manager.Setter.Single(Query.SetNewCourse(name, startedOn, finishedOn));
        }

        /// <summary>
        /// Обнуление таблицы Курсов и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Course> NullifyCourses()
        {
            return (IEnumerable<Course>)Manager.Nullify.Null(Query.NullifyCourses());
        }
    }
}