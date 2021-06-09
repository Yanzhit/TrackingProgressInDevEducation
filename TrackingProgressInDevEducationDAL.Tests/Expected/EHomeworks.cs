using System.Collections;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Tables;

namespace TrackingProgressInDevEducationDAL.Tests.Expected
{
    /// <summary>
    /// Ожидаемый результат для разных запросов
    /// </summary>
    class EHomeworks
    {
        /// <summary>
        /// Добавить новую домашнюю работу
        /// </summary>
        /// <returns></returns>
        public static IEnumerable SetNewHW()
        {
            yield return new object[] { new QHomework(), new Homework(new object[] {"C# dz","rrr"}), 1 };
            yield return new object[] { new QHomework(), new Homework(new object[] {"Java dz", "III"}), 1 };
        }
        /// <summary>
        /// Очистка таблицы домашних работ
        /// </summary>
        /// <returns></returns>
        public static IEnumerable NullifyHWs()
        {
            yield return new object[] { new QHomework(), 1 };
            yield return new object[] { new QHomework(), 1 };
        }
    }
}
