using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Abstarcts;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Cities : AFacade
    {
        /// <summary>
        /// Создать новый город
        /// </summary>
        /// <param name="name">Имя города</param>
        /// <returns>Город</returns>
        public QCity Query { get; set; }
        public City SetNewCity(string name)
        {
            return (City) _querySet.QuerySet(Query.SetNewCity(name));
        }

        /// <summary>
        /// Получить все города
        /// </summary>
        /// <returns></returns>
        public IEnumerable<City> GetAllCities()
        {
            return (List<City>) _querySet.QuerySet(Query.GetAllCities());
        }

        /// <summary>
        /// Обнуление таблицы Городов и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<City> NullifyCities()
        {
            return (List<City>) _querySet.QuerySet(Query.NullifyCities());
        }
    }
}