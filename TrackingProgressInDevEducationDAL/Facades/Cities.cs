using System.Collections.Generic;
using System.Threading.Tasks;
using TrackingProgressInDevEducationDAL.Abstracts;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Models.Results;
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
        public AResult SetNewCity(string name)
        {
            return (AResult)Manager.Setter.Single(Query.SetNewCity(name));
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
        public IEnumerable<AResult> NullifyCities()
        {
            return (IEnumerable<AResult>)Manager.Remove.Rem(Query.NullifyCities());
        }
    }
}