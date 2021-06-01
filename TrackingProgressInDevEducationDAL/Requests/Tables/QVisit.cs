using System;
using TrackingProgressInDevEducationDAL.Interfaces;
using TrackingProgressInDevEducationDAL.Models.Bases;
using static TrackingProgressInDevEducationDAL.Defines;
//ZLoo (Свойства все, Методы(SetNewVisit(проверить входные параметры), NullifyVisits))
namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    /// <summary>
    /// Запросы для таблицы посещений
    /// </summary>
    public class QVisit : IQuery
    {
        public Type Type { get; } = typeof(Visit);
        public TypeQueries TypeQueries { get; set; }
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
            TypeQueries = TypeQueries.Single;
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
            TypeQueries = TypeQueries.Nullify;
            Name = nameof(NullifyVisits);
            Params = string.Empty;
            return this;
        }

        //public QVisit GetVisitById(int id)
        //{
        //    TypeQueries = TypeQueries.GetOne;
        //    Name = nameof(GetVisitById);
        //    Params = $"{id}";
        //    return this;
        //}
        //public QVisit GetVisits()
        //{
        //    TypeQueries = TypeQueries.GetSeveral;
        //    Name = nameof(GetVisits);
        //    Params = string.Empty;
        //    return this;
        //}
        //public QVisit RemoveVisitById(int id)
        //{
        //    TypeQueries = TypeQueries.RemoveOne;
        //    Name = nameof(RemoveVisitById);
        //    Params = $"{id}";
        //    return this;
        //}
        //public QVisit UpdateVisitById(int id, bool visitStatus, int studentId, int lectionId)
        //{
        //    TypeQueries = TypeQueries.UpdateOne;
        //    Name = nameof(UpdateVisitById);
        //    Params = $"{id}{Sep}{visitStatus}{Sep}{studentId}{Sep}{lectionId}";
        //    return this;
        //}
    }
}