using System;
using TrackingProgressInDevEducationDAL.Interfaces;
using TrackingProgressInDevEducationDAL.Models.Bases;
using static TrackingProgressInDevEducationDAL.Defines;
//ZLoo (Свойства все, Методы(SetNewTStudent, NullifyTStudent))
namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    /// <summary>
    /// Запросы для таблицы команд студентов
    /// </summary>
    public class QTStudent : IQuery
    {
        public Type Type { get; } = typeof(TeamStudent);
        public TypeQueries TypeQueries { get; set; }
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
            TypeQueries = TypeQueries.Single;
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
            TypeQueries = TypeQueries.Nullify;
            Name = nameof(NullifyTStudent);
            Params = string.Empty;
            return this;
        }
    }
}