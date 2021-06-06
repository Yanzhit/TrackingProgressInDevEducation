using System;
using NUnit.Framework;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests;
using TrackingProgressInDevEducationDAL.Tests.Abstract;
using TrackingProgressInDevEducationDAL.Tests.Expected;

namespace TrackingProgressInDevEducationDAL.Tests.Tests
{
    /// <summary>
    /// Тестирование всех запросов работающих только с таблицей Домашних работ группы
    /// </summary>
    public class THWGroups : ATTests
    {
        /// <summary>
        /// Добавление новой  домашней работы группы в таблицу
        /// </summary>
        /// <param name="query">Запрос</param>
        /// <param name="hWGroup">Входящяя домашняя работа группы</param>
        /// <param name="expected">Ожидаемый результат</param>
        [TestCaseSource(typeof(EHWGroups), nameof(EHWGroups.SetNewHWGroup))]
        public void SetNewHWGroupTest(IQuery query, HWGroup hWGroup, object expected)
        {
            PreparindDB(query.QueryType);
            DalManager.HWGroups.SetNewHWGroup(hWGroup);
            //Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тест на обнуления таблицы домашних работ группы
        /// </summary>
        /// <param name="query">Запрос</param>
        /// <param name="expected">Ожидаемый результат</param>
        [TestCaseSource(typeof(EHWGroups), nameof(EHWGroups.NullifyHWGroup))]
        public void NullifyHWGroupTest(IQuery query, object expected)
        {
            PreparindDB(query.QueryType);
            DalManager.HWGroups.NullifyHWGroup();
            //Assert.AreEqual(expected, actual);
        }
    }
}
