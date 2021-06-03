using System;
using NUnit.Framework;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;
using TrackingProgressInDevEducationDAL.Tests.Abstract;
using TrackingProgressInDevEducationDAL.Tests.Expected;

namespace TrackingProgressInDevEducationDAL.Tests.Tests
{
    /// <summary>
    /// Тестирование всех запросов работающих только с таблицей Лекций
    /// </summary>
    public class TLections : ATTests
    {
        /// <summary>
        /// Добавление новой  лекции в таблицу
        /// </summary>
        /// <param name="query">Запрос</param>
        /// <param name="lection">Входящяя лекция</param>
        /// <param name="expected">Ожидаемый результат</param>
        [TestCaseSource(typeof(ELections), nameof(ELections.SetNewLection))]
        public void SetNewLectionTest(IQuery query, Lection lection, object expected)
        {
            PreparindDB(query.Type);
            FacadeManager.Lections.SetNewLection(lection.CourseId, lection.LectorId, lection.StartedOn);
            //Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тест на обнуления таблицы лекций
        /// </summary>
        /// <param name="query">Запрос</param>
        /// <param name="expected">Ожидаемый результат</param>
        [TestCaseSource(typeof(ELections), nameof(ELections.NullifyLections))]
        public void NullifyLectionsTest(IQuery query, object expected)
        {
            PreparindDB(query.Type);
            FacadeManager.Lections.NullifyLections();
            //Assert.AreEqual(expected, actual);
        }
    }
}
