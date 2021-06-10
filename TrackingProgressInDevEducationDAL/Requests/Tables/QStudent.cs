using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Others;
using TrackingProgressInDevEducationDAL.Models.Results;
using static TrackingProgressInDevEducationDAL.Defines;

namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    public class QStudent : IQuery
    {
        public Type QueryType { get; set; }
        public Type ModelType { get; } = typeof(Student);
        public string Name { get; set; }
        public string Params { get; set; }

        /// <summary>
        /// Создание нового студента
        /// </summary>
        /// <param name="student">Объект данных</param>
        /// <returns>Подготовленный запрос</returns>
        public QStudent SetNewStudent(Student student)
        {
            QueryType = typeof(Setter);
            Name = nameof(SetNewStudent);
            Params = $"{SepStr}{student.Name}{SepMid}{student.Surname}{SepMid}{student.Rate}{SepMid}{student.GroupId}{SepMid}" +
                     $"{student.Phone}{SepMid}{student.Email}{SepMid}{student.Contract}{SepMid}{student.Birthday}{SepMid}" +
                     $"{student.MiddleName}{SepMid}{student.Git}{SepMid}{student.CityId}{SepMid}{student.Status}{SepEnd}";
            return this;
        }

        /// <summary>
        /// Получить всех студентов из таблицы
        /// </summary>
        /// <returns>Подготовленный запрос</returns>
        public QStudent GetAllStudents()
        {
            QueryType = typeof(Getter);
            Name = nameof(GetAllStudents);
            Params = string.Empty;
            return this;
        }

        public QStudent UpdStudentToGroup()
        {
            QueryType = typeof(Update);
            Name = nameof(UpdStudentToGroup);
            Params = string.Empty;
            return this;
        }

        /// <summary>
        /// Обнуление таблицы студентов и ключа identity
        /// </summary>
        /// <returns>Подготовленный запрос</returns>
        public QStudent NullifyStudents()
        {
            QueryType = typeof(Remove);
            Name = nameof(NullifyStudents);
            Params = string.Empty;
            return this;
        }

        //public QStudent GetByIdStudent(int id)
        //{
        //    Name = nameof(GetByIdStudent);
        //    Params = $"{id}";
        //    return this;
        //}
    }
}