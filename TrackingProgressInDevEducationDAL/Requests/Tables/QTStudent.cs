using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using static TrackingProgressInDevEducationDAL.Defines;
//ZLoo (Свойства все, Методы(SetNewTStudent, NullifyTStudent))
namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    /// <summary>
    /// Запросы для таблицы команд студентов
    /// </summary>
    public class QTStudent : IQuery
    {
        public Type QueryType { get; set; }
        public Type ModelType { get; } = typeof(TStudent);
        public string Name { get; set; }
        public string Params { get; set; }

        /// <summary>
        /// Создание новой команды
        /// </summary>
        /// <param name="tStudent">Объект данных</param>
        /// <returns>Подготовленный запрос</returns>
        public QTStudent SetNewTStudent(TStudent tStudent)
        {
            QueryType = typeof(Setter);
            Name = nameof(SetNewTStudent);
            Params = $"{SepStr}{tStudent.TeamId}{SepMid}{tStudent.StudentId}{SepEnd}";
            return this;
        }
        
        /// <summary>
        /// Обнуление таблицы команд студентов и ключа identity
        /// </summary>
        /// <returns>Подготовленный запрос</returns>
        public QTStudent NullifyTStudent()
        {
            QueryType = typeof(Remove);
            Name = nameof(NullifyTStudent);
            Params = string.Empty;
            return this;
        }

        //public QTStudent GetAllTStudents()
        //{
        //    QueryType = typeof(Getter);
        //    Name = nameof(GetAllTStudents);
        //    Params = $"";
        //    return this;
        //}
        //public QTStudent GetAllTStudentsByGroup()
        //{
        //    QueryType = typeof(Getter);
        //    Name = nameof(GetAllTStudentsByGroup);
        //    Params = $"";
        //    return this;
        //}
        //public QTStudent UpdTStudentToGroup()
        //{
        //    QueryType = typeof(Update);
        //    Name = nameof(UpdTStudentToGroup);
        //    Params = $"";
        //    return this;
        //}
    }
}