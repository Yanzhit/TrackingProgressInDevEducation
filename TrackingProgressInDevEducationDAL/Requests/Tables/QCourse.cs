using System;
using TrackingProgressInDevEducationDAL.Interfaces;
using TrackingProgressInDevEducationDAL.Models.Bases;
using static TrackingProgressInDevEducationDAL.Defines;
//ZLoo (Свойства все, Методы(SetNewCourse, NullifyCourses)
namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    /// <summary>
    /// Запросы к таблице курсов
    /// </summary>
    public class QCourse : IQuery
    {
        public Type Type { get; } = typeof(Course);
        public TypeQueries TypeQueries { get; set; }
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
            TypeQueries = TypeQueries.Single;
            Name = nameof(SetNewCourse);
            Params = $"{name}{Sep}{startedOn}{Sep}{finishedOn}";
            return this;
        }

        /// <summary>
        /// Обнуление таблицы курсов и ключа identity
        /// </summary>
        /// <returns>Подготовленный запрос</returns>
        public QCourse NullifyCourses()
        {
            TypeQueries = TypeQueries.Nullify;
            Name = nameof(NullifyCourses);
            Params = string.Empty;
            return this;
        }

        //public QCourse GetAllCourses()
        //{
        //    TypeQueries = TypeQueries.GetOne;
        //    Name = nameof(GetAllCourses);
        //    Params = string.Empty;
        //    return this;
        //}
        //public QCourse RemoveCourseById(int id)
        //{
        //    TypeQueries = TypeQueries.RemoveOne;
        //    Name = nameof(RemoveCourseById);
        //    Params = $"{id}";
        //    return this;
        //}
    }
}