using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Facades.Interfaces;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Cities : AFacade, ICities
    {
        private readonly QCity _query = new();

        /// <summary>
        /// Создать новый город
        /// </summary>
        /// <param name="city">Объект данных</param>
        /// <returns>Город</returns>
        public City SetNewCity(City city)
        {
            return (City)Manager.Setter.Single(_query.SetNewCity(city));
        }

        /// <summary>
        /// Получить все города
        /// </summary>
        /// <returns></returns>
        public IEnumerable<City> GetCities()
        {
            return (IEnumerable<City>)Manager.Getter.Several(_query.GetAllCities());
        }

        /// <summary>
        /// Обнуление таблицы Городов и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<City> NullifyCities()
        {
            return (IEnumerable<City>)Manager.Remove.Rem(_query.NullifyCities());
        }
    }
}