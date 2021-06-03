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
        public Type Type { get; set; } = typeof(AResult);
        public Type Test { get; } = typeof(TStudent);
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
            Name = nameof(SetNewTStudent);
            Params = $"{teamId}{Sep}{studentId}";
            return this;
        }
        /// <summary>
        /// Обнуление таблицы команд студентов и ключа identity
        /// </summary>
        /// <returns>Подготовленный запрос</returns>
        public QTStudent NullifyTStudent()
        {
            Name = nameof(NullifyTStudent);
            Params = string.Empty;
            return this;
        }
    }
}