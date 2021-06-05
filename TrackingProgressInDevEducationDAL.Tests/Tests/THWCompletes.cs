using System;
using NUnit.Framework;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;
using TrackingProgressInDevEducationDAL.Tests.Abstract;
using TrackingProgressInDevEducationDAL.Tests.Expected;

namespace TrackingProgressInDevEducationDAL.Tests.Tests
{
    /// <summary>
    /// Тестирование всех запросов работающих только с таблицей Выполненных домашних работ
    /// </summary>
    public class THWCompletes : ATTests
    {
        /// <summary>
        /// Добавление новой  выполненной домашней работы в таблицу
        /// </summary>
        /// <param name="query">Запрос</param>
        /// <param name="hWComplete">Входящяя выполненная домашняя работа</param>
        /// <param name="expected">Ожидаемый результат</param>
        [TestCaseSource(typeof(EHWCompletes), nameof(EHWCompletes.SetNewHWComplete))]
        public void SetNewHWCompleteTest(IQuery query, HWComplete hWComplete, object expected)
        {
            PreparindDB(query.QueryType);
            FacadeManager.HWCompletes.SetNewHWComplete(hWComplete.HomeworkId, hWComplete.StudentId, hWComplete.Status);
            //Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тест на обнуления таблицы выполненных домашних работ
        /// </summary>
        /// <param name="query">Запрос</param>
        /// <param name="expected">Ожидаемый результат</param>
        [TestCaseSource(typeof(EHomeworks), nameof(EHomeworks.NullifyHWs))]
        public void NullifyHWCompleteTest(IQuery query, object expected)
        {
            PreparindDB(query.QueryType);
            FacadeManager.HWCompletes.NullifyHWComplete();
            //Assert.AreEqual(expected, actual);
        }
    }
}
