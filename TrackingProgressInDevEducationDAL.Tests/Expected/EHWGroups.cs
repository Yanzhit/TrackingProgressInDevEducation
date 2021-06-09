using System.Collections;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Tests.Expected
{
    /// <summary>
    /// Ожидаемый результат для разных запросов
    /// </summary>
    public class EHWGroups
    {
        /// <summary>
        /// Добавление новой домашней работы группы в таблицу
        /// </summary>
        /// <returns></returns>
        public static IEnumerable SetNewHWGroup()
        {
            yield return new object[] { new QHWGroup(), new HWGroup(new object[] {2, 1}), 1 };
            yield return new object[] { new QHWGroup(), new HWGroup(new object[] {1, 2}), 1 };
        }

        /// <summary>
        /// Очистка таблицы домашних работ группы
        /// </summary>
        /// <returns></returns>
        public static IEnumerable NullifyHWGroup()
        {
            yield return new object[] { new QHWGroup(), 1 };
            yield return new object[] { new QHWGroup(), 1 };
        }
    }
}
