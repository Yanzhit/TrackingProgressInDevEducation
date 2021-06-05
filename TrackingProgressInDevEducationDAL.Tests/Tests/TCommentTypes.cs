using System;
using NUnit.Framework;
using TrackingProgressInDevEducationDAL.Facades;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;
using TrackingProgressInDevEducationDAL.Tests.Abstract;
using TrackingProgressInDevEducationDAL.Tests.Expected;

namespace TrackingProgressInDevEducationDAL.Tests.Tests
{
    /// <summary>
    /// Тестирование всех запросов работающих только с таблицей Типы комментариев
    /// </summary>
    public class TCommentTypes : ATTests
    {
        /// <summary>
        /// Добавление нового типа коментария в таблицу
        /// </summary>
        /// <param name="query">Запрос</param>
        /// <param name="commentType">Входящий тип комментария</param>
        /// <param name="expected">Ожидаемый результат</param>
        [TestCaseSource(typeof(ECommentTypes), nameof(ECommentTypes.SetNewCType))]
        public void SetNewCTypeTest(IQuery query, CType commentType, object expected)
        {
            PreparindDB(query.ModelType);
            FacadeManager.CTypes.SetNewCType(commentType.Name);
            //Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тест на обнуления таблицы типа коментариев 
        /// </summary>
        /// <param name="query">Запрос</param>
        /// <param name="expected">Ожидаемый результат</param>
        [TestCaseSource(typeof(ECommentTypes), nameof(ECommentTypes.NullifyCTypes))]
        public void NullifyCTypesTest(IQuery query, object expected)
        {
            PreparindDB(query.ModelType);
            FacadeManager.CTypes.NullifyCTypes();
            //Assert.AreEqual(expected, actual);
        }
    }
}
