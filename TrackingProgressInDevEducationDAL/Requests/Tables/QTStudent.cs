using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;
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
        /// <param name="teamId">id команды</param>
        /// <param name="studentId">id студента</param>
        /// <returns>Подготовленный запрос</returns>
        public QTStudent SetNewTStudent(int teamId, int studentId)
        {
            QueryType = typeof(Setter);
            Name = nameof(SetNewTStudent);
            Params = $"{SepStr}{teamId}{SepMid}{studentId}{SepEnd}";
            return this;
        }

        public QTStudent GetAllStudents()
        {
            QueryType = typeof(Getter);
            Name = nameof(GetAllStudents);
            Params = $"";
            return this;
        }
        public QTStudent GetAllStudentsByGroup()
        {
            QueryType = typeof(Getter);
            Name = nameof(GetAllStudentsByGroup);
            Params = $"";
            return this;
        }
        public QTStudent UpdStudentToGroup()
        {
            QueryType = typeof(Update);
            Name = nameof(UpdStudentToGroup);
            Params = $"";
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
    }
}