using System;
using NUnit.Framework;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;
using TrackingProgressInDevEducationDAL.Tests.Abstract;
using TrackingProgressInDevEducationDAL.Tests.Expected;

namespace TrackingProgressInDevEducationDAL.Tests.Tests
{
    /// <summary>
    /// Тестирование всех запросов работающих только с таблицей Коментариев
    /// </summary>
    public class TComments : ATTests
    {
        /// <summary>
        /// Добавление нового коментария в таблицу
        /// </summary>
        /// <param name="query">Запрос</param>
        /// <param name="comment">Входящий коментарий</param>
        /// <param name="expected">Ожидаемый результат</param>
        [TestCaseSource(typeof(EComments), nameof(EComments.SetNewComment))]
        public void SetNewCommentTest(IQuery query, Comment comment, object expected)
        {
            PreparindDB(query.ModelType);
            FacadeManager.Comments.SetNewComment
            (
                comment.Text, 
                comment.TypeId, 
                comment.StudentId, 
                comment.CreatedBy, 
                comment.TeamId
            );
            //Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тест на обнуления таблицы коментариев
        /// </summary>
        /// <param name="query">Запрос</param>
        /// <param name="expected">Ожидаемый результат</param>
        [TestCaseSource(typeof(EComments), nameof(EComments.NullifyComments))]
        public void NullifyCommentsTest(IQuery query, object expected)
        {
            PreparindDB(query.ModelType);
            FacadeManager.Comments.NullifyComments();
            //Assert.AreEqual(expected, actual);
        }
    }
}
