using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;
using static TrackingProgressInDevEducationDAL.Defines;
//ZLoo (Свойства все, Методы(SetNewVisit(проверить входные параметры), NullifyVisits))
namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    /// <summary>
    /// Запросы для таблицы посещений
    /// </summary>
    public class QVisit : IQuery
    {
        public Type Type { get; set; } = typeof(AResult);
        public Type Test { get; } = typeof(Visit);
        public string Name { get; set; }
        public string Params { get; set; }

        /// <summary>
        /// Создание нового посещения
        /// </summary>
        /// <param name="visitStatus">Статус посещения (0;1)</param>
        /// <param name="studentId">id студента</param>
        /// <param name="lectionId">id лекции</param>
        /// <returns>Подготовленный запрос</returns>
        public QVisit SetNewVisit(bool visitStatus, int studentId, int lectionId)
        {
            Name = nameof(SetNewVisit);
            Params = $"{visitStatus}{Sep}{studentId}{Sep}{lectionId}";
            return this;
        }

        /// <summary>
        /// Обнуление таблицы посещений и ключа identity
        /// </summary>
        /// <returns>Подготовленный запрос</returns>
        public QVisit NullifyVisits()
        {
            Name = nameof(NullifyVisits);
            Params = string.Empty;
            return this;
        }

        //public QVisit GetVisitById(int id)
        //{
        //    Name = nameof(GetVisitById);
        //    Params = $"{id}";
        //    return this;
        //}
        //public QVisit GetVisits()
        //{
        //    Name = nameof(GetVisits);
        //    Params = string.Empty;
        //    return this;
        //}
        //public QVisit RemoveVisitById(int id)
        //{
        //    Name = nameof(RemoveVisitById);
        //    Params = $"{id}";
        //    return this;
        //}
        //public QVisit UpdateVisitById(int id, bool visitStatus, int studentId, int lectionId)
        //{
        //    Name = nameof(UpdateVisitById);
        //    Params = $"{id}{Sep}{visitStatus}{Sep}{studentId}{Sep}{lectionId}";
        //    return this;
        //}
    }
}