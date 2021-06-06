using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using static TrackingProgressInDevEducationDAL.Defines;
//ZLoo (Свойства все, Методы(SetNewCourse, NullifyCourses)
namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    /// <summary>
    /// Запросы к таблице курсов
    /// </summary>
    public class QCourse : IQuery
    {
        public Type QueryType { get; set; }
        public Type ModelType { get; } = typeof(Course);
        public string Name { get; set; }
        public string Params { get; set; }

        /// <summary>
        /// Создать новый курс
        /// </summary>
        /// <param name="course">Объект данных</param>
        /// <returns>Подготовленный запрос</returns>
        public QCourse SetNewCourse(Course course)
        {
            QueryType = typeof(Setter);
            Name = nameof(SetNewCourse);
            Params = $"{SepStr}{course.Name}{SepMid}{course.StartedOn}{SepMid}{course.FinishedOn}{SepEnd}";
            return this;
        }

        public QCourse GetAllCourses()
        {
            QueryType = typeof(Getter);
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