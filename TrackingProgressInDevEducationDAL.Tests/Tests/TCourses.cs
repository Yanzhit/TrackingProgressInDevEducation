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
    /// Тестирование всех запросов работающих только с таблицей Курсы
    /// </summary>
    public class TCourses : ATTests
    {
        /// <summary>
        /// Добавление нового курса в таблицу
        /// </summary>
        /// <param name="query">Запрос</param>
        /// <param name="course">Входящий курс</param>
        /// <param name="expected">Ожидаемый результат</param>
        [TestCaseSource(typeof(ECourses), nameof(ECourses.SetNewCourse))]
        public void SetNewCourseTest(IQuery query, Course course, object expected)
        {
            PreparindDB(query.ModelType);
            DalManager.Courses.SetNewCourse(course);
            //Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тест на обнуления таблицы курсов
        /// </summary>
        /// <param name="query">Запрос</param>
        /// <param name="expected">Ожидаемый результат</param>
        [TestCaseSource(typeof(ECourses), nameof(ECourses.NullifyCourses))]
        public void NullifyCoursesTests(IQuery query, object expected)
        {
            PreparindDB(query.ModelType);
            DalManager.Courses.NullifyCourses();
            //Assert.AreEqual(expected, actual);
        }
    }
}
