using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.ForTables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Cities
    {
        private readonly QCity _qCity = new();
        private readonly QuerySettings _query = new();

        /// <summary>
        /// Создать новый город
        /// </summary>
        /// <param name="name">Имя города</param>
        /// <returns>Город</returns>
        public City SetNewCity(string name)
        {
            return (City) _query.QuerySet(_qCity.SetNewCity(name));
        }

        /// <summary>
        /// Получить все города
        /// </summary>
        /// <returns></returns>
        public IEnumerable<City> GetAllCities()
        {
            return (List<City>) _query.QuerySet(_qCity.GetAllCities());
        }

        /// <summary>
        /// Обнуление таблицы Городов и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<City> NullifyCities()
        {
            return (List<City>) _query.QuerySet(_qCity.NullifyCities());
        }
    }
}