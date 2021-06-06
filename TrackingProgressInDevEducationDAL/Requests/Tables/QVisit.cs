using System;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
using static TrackingProgressInDevEducationDAL.Defines;
//ZLoo (Свойства все, Методы(SetNewVisit(проверить входные параметры), NullifyVisits))
namespace TrackingProgressInDevEducationDAL.Requests.Tables
{
    /// <summary>
    /// Запросы для таблицы посещений
    /// </summary>
    public class QVisit : IQuery
    {
        public Type QueryType { get; set; }
        public Type ModelType { get; } = typeof(Visit);
        public string Name { get; set; }
        public string Params { get; set; }

        /// <summary>
        /// Создание нового посещения
        /// </summary>
        /// <param name="visit">Объект данных</param>
        /// <returns>Подготовленный запрос</returns>
        public QVisit SetNewVisit(Visit visit)
        {
            QueryType = typeof(Setter);
            Name = nameof(SetNewVisit);
            Params = $"{SepStr}{visit.VisitStatus}{SepMid}{visit.StudentId}{SepMid}{visit.LectionId}{SepEnd}";
            return this;
        }

        public QVisit GetVisitsScore()
        {
            QueryType = typeof(Getter);
            Name = nameof(GetVisitsScore);
            Params = $"";
            return this;
        }

        /// <summary>
        /// Обнуление таблицы посещений и ключа identity
        /// </summary>
        /// <returns>Подготовленный запрос</returns>
        public QVisit NullifyVisits()
        {
            QueryType = typeof(Remove);
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