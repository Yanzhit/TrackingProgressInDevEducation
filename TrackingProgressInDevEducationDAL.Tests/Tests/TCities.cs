using System;
using NUnit.Framework;
using TrackingProgressInDevEducationDAL.Interfaces;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Tests.Abstract;
using TrackingProgressInDevEducationDAL.Tests.Expected;

namespace TrackingProgressInDevEducationDAL.Tests.Tests
{
    /// <summary>
    /// Тестирование всех запросов работающих только с таблицей Городов
    /// </summary>
    public class TCities : ATTests
    {
        /// <summary>
        /// Добавление нового города в таблицу
        /// </summary>
        /// <param name="query">Запрос</param>
        /// <param name="name">Входящие имя города</param>
        /// <param name="expected">Ожидаемый результат</param>
        [TestCaseSource(typeof(ECities), nameof(ECities.SetNewCity))]
        public void SetNewCitiesTest(IQuery query, City city, object expected)
        {
            PreparindDB(query.Type);
            _manager.Cities.SetNewCity(city.Name);
            //Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Получение всех городов из таблицы
        /// </summary>
        /// <param name="query">Запрос</param>
        /// <param name="expected">Ожидаемый результат</param>
        [TestCaseSource(typeof(ECities), nameof(ECities.GetAllCities))]
        public void GetAllCitiesTest(IQuery query, object expected)
        {
            PreparindDB(query.Type);
            _manager.Cities.GetAllCities();
            //Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тест на обнуления таблицы городов
        /// </summary>
        /// <param name="query">Запрос</param>
        /// <param name="expected">Ожидаемый результат</param>
        [TestCaseSource(typeof(ECities), nameof(ECities.NullifyCities))]
        public void NullifyCitiesTest(IQuery query, object expected)
        {
            PreparindDB(query.Type);
            _manager.Cities.NullifyCities();
            //Assert.AreEqual(expected, actual);
        }
    }
}