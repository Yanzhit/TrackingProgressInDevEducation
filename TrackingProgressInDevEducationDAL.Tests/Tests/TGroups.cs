using System;
using NUnit.Framework;
using TrackingProgressInDevEducationDAL.Facades;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests;
using TrackingProgressInDevEducationDAL.Tests.Abstract;
using TrackingProgressInDevEducationDAL.Tests.Expected;

namespace TrackingProgressInDevEducationDAL.Tests.Tests
{
    /// <summary>
    /// Тестирование всех запросов работающих только с таблицей групп
    /// </summary>
    public class TGroups : ATTests
    {
        /// <summary>
        /// Добавление новой группы в таблицу
        /// </summary>
        /// <param name="query">Запрос</param>
        /// <param name="group">Входящая группа</param>
        /// <param name="expected">Ожидаемый результат</param>
        [TestCaseSource(typeof(EGroups), nameof(EGroups.SetNewGroup))]
        public void SetNewGroupTest(IQuery query, Group group, object expected)
        {
            PreparindDB(query.ModelType);
            DalManager.Groups.SetNewGroup(group);
            //Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Тест на обнуления таблицы групп
        /// </summary>
        /// <param name="query">Запрос</param>
        /// <param name="expected">Ожидаемый результат</param>
        [TestCaseSource(typeof(EGroups), nameof(EGroups.NullifyGroups))]
        public void NullifyGroupsTest(IQuery query, object expected)
        {
            PreparindDB(query.ModelType);
            DalManager.Groups.NullifyGroups();
            //Assert.AreEqual(expected, actual);
        }
    }
}
