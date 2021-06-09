using System;
using System.Collections;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Tests.Expected
{
    /// <summary>
    /// Ожидаемый результат для разных запросов
    /// </summary>
    class ELectors
    {
        /// <summary>
        /// Добавление новых Лекторов в таблицу
        /// </summary>
        /// <returns></returns>
        public static IEnumerable SetNewLector()
        {
            yield return new object[] { new QLector(), new Lector("Wood","Вася", "лгбт", "ВадимГрут"), 1 };
            yield return new object[] { new QLector(), new Lector("Cool","Петя", "ЖМЖ", "Волоннн"), 1 };
        }

        /// <summary>
        /// Очистка таблицы Лекторов  
        /// </summary>
        /// <returns></returns>
        public static IEnumerable NullifyLectors()
        {
            yield return new object[] { new QLector(), 1 };
            yield return new object[] { new QLector(), 1 };
        }
    }
}
