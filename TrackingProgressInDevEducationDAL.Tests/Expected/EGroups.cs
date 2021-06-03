using System;
using System.Collections;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Tests.Expected
{
    /// <summary>
    /// Ожидаемый результат для разных запросов
    /// </summary>
    public class EGroups
    {
        /// /// <summary>
        /// Добавить новую группу в таблицу групп
        /// </summary>
        /// <returns></returns>
        public static IEnumerable SetNewGroup()
        {
            yield return new object[]
            {
                new QComment(),
                new Group("", 2, DateTime.MaxValue, DateTime.Now),
                1
            };
            yield return new object[]
            {
                new QComment(),
                new Group("", 1, DateTime.MaxValue, DateTime.Now),
                1
            };
        }
        /// <summary>
        /// Очистка таблицы групп 
        /// </summary>
        /// <returns></returns>
        public static IEnumerable NullifyGroups()
        {
            yield return new object[]
            {
                new QComment(),
                1
            };
        }
    }
}
