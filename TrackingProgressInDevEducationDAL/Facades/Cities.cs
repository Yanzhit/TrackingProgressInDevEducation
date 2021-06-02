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
            return (City)QuerySet.QuerySet(Query.SetNewCity(name));
        }

        /// <summary>
        /// Получить все города
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<City>> GetAllCities()
        {
            return (IEnumerable<City>)QuerySet.QuerySet(Query.GetAllCities());
        }

        /// <summary>
        /// Обнуление таблицы Городов и ключа identity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<City> NullifyCities()
        {
            return (List<City>)QuerySet.QuerySet(Query.NullifyCities());
        }
    }
}