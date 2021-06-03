using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;
using static TrackingProgressInDevEducationDAL.Defines;
//ZLoo (Свойства все, Методы(SetNewCourse, NullifyCourses)
namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    /// <summary>
    /// Запросы к таблице курсов
    /// </summary>
    public class QCourse : IQuery
    {
        public Type Type { get; set; }
        public Type Test { get; } = typeof(Course);
        public string Name { get; set; }
        public string Params { get; set; }

        /// <summary>
        /// Создание нового курса
        /// </summary>
        /// <param name="name">Название курса</param>
        /// <param name="startedOn">Дата начала курса</param>
        /// <param name="finishedOn">Дата завершения курса</param>
        /// <returns>Подготовленный запрос</returns>
        public QCourse SetNewCourse(string name, DateTime startedOn, DateTime finishedOn)
        {
            Type = typeof(Setter);
            Name = nameof(SetNewCourse);
            Params = $"{name}{Sep}{startedOn}{Sep}{finishedOn}";
            return this;
        }

        public QCourse GetAllCourses()
        {
            Type = typeof(Getter);
            Name = nameof(GetAllCourses);
            Params = string.Empty;
            return this;
        }

        /// <summary>
        /// Обнуление таблицы курсов и ключа identity
        /// </summary>
        /// <returns>Подготовленный запрос</returns>
        public QCourse NullifyCourses()
        {
            Name = nameof(Remove);
            Params = string.Empty;
            return this;
        }

        //public QCourse GetAllCourses()
        //{
        //    Name = nameof(GetAllCourses);
        //    Params = string.Empty;
        //    return this;
        //}
        //public QCourse RemoveCourseById(int id)
        //{
        //    Name = nameof(RemoveCourseById);
        //    Params = $"{id}";
        //    return this;
        //}
    }
}