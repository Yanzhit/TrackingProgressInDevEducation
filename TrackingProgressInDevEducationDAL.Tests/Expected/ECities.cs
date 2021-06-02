using System.Collections;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Tests.Expected
{
    /// <summary>
    /// Ожидаемый результат для разных запросов
    /// </summary>
    public class ECities
    {
        /// <summary>
        /// Добавить новый город в таблицу городов
        /// </summary>
        /// <returns></returns>
        public static IEnumerable SetNewCity()
        {
            yield return new object[] {new QCity(), "Сарай", 1};
            yield return new object[] {new QCity(), "Сарай", 1};
        }

        /// <summary>
        /// Получить все города из таблицы городов
        /// </summary>
        /// <returns></returns>
        public static IEnumerable GetAllCities()
        {
            yield return new object[] {new QCity(), 1};
            yield return new object[] {new QCity(), 1};
        }

        /// <summary>
        /// Очистка таблицы городов
        /// </summary>
        /// <returns></returns>
        public static IEnumerable NullifyCities()
        {
            yield return new object[] {new QComment(), 1};
            yield return new object[] {new QComment(), 1};
        }
    }
}