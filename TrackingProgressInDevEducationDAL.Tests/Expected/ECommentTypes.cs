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
    public class ECommentTypes
    {
        /// <summary>
        /// Добавить новый тип коментариев в таблицу типа коментариев
        /// </summary>
        /// <returns></returns>
        public static IEnumerable SetNewCType()
        {
            yield return new object[]
            {
                new QComment(),
                new CType(""),
                1
            };
            yield return new object[]
           {
                new QComment(),
                new CType(""),
                1
           };
        }

        /// <summary>
        /// Очистка таблицы Типа коментариев
        /// </summary>
        /// <returns></returns>
        public static IEnumerable NullifyCTypes()
        {
            yield return new object[]
            {
                new QComment(),
                1
            };
        }
    }
}
