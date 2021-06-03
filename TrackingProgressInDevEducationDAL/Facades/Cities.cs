using System.Collections.Generic;
using System.Threading.Tasks;
using TrackingProgressInDevEducationDAL.Abstracts;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Facades
{
    public class Cities : AFacade
    {
        public QCity Query { get; init; }

        /// <summary>
        /// Создать новый город
        /// </summary>
        /// <param name="name">Имя города</param>
        /// <returns>Город</returns>
        public City SetNewCity(string name)
        {
            return (City)Manager.Setter.Single(Query.SetNewCity(name));
        }

        /// <summary>
        /// Получить все города
        /// </summary>
        /// <returns></returns>
        public IEnumerable<City> GetAllCities()
        {
            return (IEnumerable<City>)Manager.Getter.Several(Query.GetAllCities());
        }

        /// <summary>
        /// Обнуление таблицы Городов и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<City> NullifyCities()
        {
            return (List<City>)Manager.Setter.Single(Query.NullifyCities());
        }
    }
}