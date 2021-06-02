using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Tests.Expected
{
    /// <summary>
    /// Ожидаемый результат для разных запросов
    /// </summary>
    public class EComments
    {
        /// <summary>
        /// Добавить новый комент в таблицу коментариев
        /// </summary>
        /// <returns></returns>
        public static IEnumerable SetNewComment()
        {
            yield return new object[]
            {
                new QComment(),
                new Comment("", 2, 3, 1, 1),
                1
            };
            yield return new object[]
           {
                new QComment(),
                new Comment("", 3, 1, 2, 3),
                1
           };
        }
        /// <summary>
        /// Очистка таблицы Коментариев
        /// </summary>
        /// <returns></returns>
        public static IEnumerable NullifyComments()
        {
            yield return new object[]
            {
                new QComment(),
                1
            };
        }
    }
}
