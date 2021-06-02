﻿using System;
using NUnit.Framework;
using TrackingProgressInDevEducationDAL.Facades;
using TrackingProgressInDevEducationDAL.Interfaces;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Tests.Abstract;
using TrackingProgressInDevEducationDAL.Tests.Expected;

namespace TrackingProgressInDevEducationDAL.Tests.Tests
{
    /// <summary>
    /// Тестирование всех запросов работающих только с таблицей Типы коментариев
    /// </summary>
    public class TCommentTypes : ATTests
    {
        /// <summary>
        /// Добавление нового типа коментария в таблицу
        /// </summary>
        /// <param name="query">Запрос</param>
        /// <param name="commentType">Входящий тип коментария</param>
        /// <param name="expected">Ожидаемый результат</param>
        [TestCaseSource(typeof(ECommentTypes), nameof(ECommentTypes.SetNewCType))]
        public void SetNewCTypeTest(IQuery query, CType commentType, object expected)
        {
            PreparindDB(query.Type);
            _manager.CTypes.SetNewCType(commentType.Name);
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
            PreparindDB(query.Type);
            _manager.CTypes.NullifyCTypes();
            //Assert.AreEqual(expected, actual);
        }
    }
}