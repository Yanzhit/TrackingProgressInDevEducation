using System;
using System.Collections;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Tests.Expected
{
    /// <summary>
    /// Ожидаемый результат для разных запросов
    /// </summary>
    public class ELections
    {
        /// <summary>
        /// Добавление новой лекции в таблицу
        /// </summary>
        /// <returns></returns>
        public static IEnumerable SetNewLection()
        {
            yield return new object[] { new QLection(), new Lection(2, 1, DateTime.MaxValue), 1 };
            yield return new object[] { new QLection(), new Lection(1, 2, DateTime.MaxValue), 1 };
        }

        /// <summary>
        /// Очистка таблицы лекций 
        /// </summary>
        /// <returns></returns>
        public static IEnumerable NullifyLections()
        {
            yield return new object[] { new QLection(), 1 };
            yield return new object[] { new QLection(), 1 };
        }
    }
}
