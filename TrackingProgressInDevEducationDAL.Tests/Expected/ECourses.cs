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
    public class ECourses
    {
        /// <summary>
        /// Добавить новый курс в таблицу курсов
        /// </summary>
        /// <returns></returns>
        public static IEnumerable SetNewCourse()
        {
            yield return new object[]
           {
                new QComment(),
                new Course("", "DateTime.MaxValue", "DateTime.MaxValue"),
                1
           };
            yield return new object[]
          {
                new QComment(),
                new Course("", "DateTime.MaxValue", "DateTime.MaxValue"),
                1
          };
        }

        /// <summary>
        /// Очистка таблицы Курсов 
        /// </summary>
        /// <returns></returns>
        public static IEnumerable NullifyCourses()
        {
            yield return new object[]
            {
                new QComment(),
                1
            };
        }
    }
}
