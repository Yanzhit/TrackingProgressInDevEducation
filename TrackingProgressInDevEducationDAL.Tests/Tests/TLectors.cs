using System;
using NUnit.Framework;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;
using TrackingProgressInDevEducationDAL.Tests.Abstract;
using TrackingProgressInDevEducationDAL.Tests.Expected;

namespace TrackingProgressInDevEducationDAL.Tests.Tests
{
    /// <summary>
    /// Тестирование всех запросов работающих только с таблицей лекторов
    /// </summary>
    public class TLectors : ATTests
    {
        /// <summary>
        /// Добавление новых лекторов в таблицу
        /// </summary>
        /// <param name="query">Запрос</param>
        /// <param name="lector">Входящий лектор(Ганибал)</param>
        /// <param name="expected">Ожидаемый результат</param>
        [TestCaseSource(typeof(ELectors), nameof(ELectors.SetNewLector))]
        public void SetNewLectorTest(IQuery query, Lector lector, object expected)
        {
            PreparindDB(query.QueryType);
            DalManager.Lectors.SetNewLector(lector.FullName, lector.Email, lector.Password);
            //Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тест на обнуления таблицы лекторов
        /// </summary>
        /// <param name="query">Запрос</param>
        /// <param name="expected">Ожидаемый результат</param>
        [TestCaseSource(typeof(ELectors), nameof(ELectors.NullifyLectors))]
        public void NullifyLectorsTest(IQuery query, object expected)
        {
            PreparindDB(query.QueryType);
            DalManager.Lectors.NullifyLectors();
            //Assert.AreEqual(expected, actual);
        }
    }
}
