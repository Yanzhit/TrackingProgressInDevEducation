using System;
using NUnit.Framework;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;
using TrackingProgressInDevEducationDAL.Tests.Abstract;
using TrackingProgressInDevEducationDAL.Tests.Expected;

namespace TrackingProgressInDevEducationDAL.Tests.Tests
{
    /// <summary>
    /// Тестирование всех запросов работающих только с таблицей Домашних работ
    /// </summary>
    public class THomeworks : ATTests
    {
        /// <summary>
        /// Добавление новой домашней работы в таблицу
        /// </summary>
        /// <param name="query">Запрос</param>
        /// <param name="homework">Входящяя домашняя работа</param>
        /// <param name="expected">Ожидаемый результат</param>
        [TestCaseSource(typeof(EHomeworks), nameof(EHomeworks.SetNewHW))]
        public void SetNewHWTest(IQuery query, Homework homework, object expected)
        {
            PreparindDB(query.QueryType);
            FacadeManager.Homeworks.SetNewHW(homework.Name);
            //Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тест на обнуления таблицы домашних работ
        /// </summary>
        /// <param name="query">Запрос</param>
        /// <param name="expected">Ожидаемый результат</param>
        [TestCaseSource(typeof(EHomeworks), nameof(EHomeworks.NullifyHWs))]
        public void NullifyCitiesTest(IQuery query, object expected)
        {
            PreparindDB(query.QueryType);
            FacadeManager.Homeworks.NullifyHWs();
            //Assert.AreEqual(expected, actual);
        }
    }
}
