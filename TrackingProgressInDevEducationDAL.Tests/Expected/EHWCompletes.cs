using System;
using System.Collections;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Tests.Expected
{
    /// <summary>
    /// Ожидаемый результат для разных запросов
    /// </summary>
    public class EHWCompletes
    {
        /// <summary>
        /// Добавление новой  выполненной домашней работы в таблицу
        /// </summary>
        /// <returns></returns>
        public static IEnumerable SetNewHWComplete()
        {
            yield return new object[] { new QHWComplete(), new HWComplete(new object[] {2, 2, true,
                "DateTime.MaxValue", 1, "DateTime.MaxValue"}), 1 };
            yield return new object[] { new QHWComplete(), new HWComplete(new object[] {1, 2, false,
                "DateTime.MaxValue", 1, "DateTime.MaxValue"}), 1 };
        }

        /// <summary>
        /// Очистка таблицы выполненных домашних работ
        /// </summary>
        /// <returns></returns>
        public static IEnumerable NullifyHWComplete()
        {
            yield return new object[] { new QHWComplete(), 1 };
            yield return new object[] { new QHWComplete(), 1 };
        }
    }
}
