using System;
using System.Collections.Generic;
using NUnit.Framework;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Requests.Interfaces;
using TrackingProgressInDevEducationDAL.Tests.Abstract;
using TrackingProgressInDevEducationDAL.Tests.Expected;

namespace TrackingProgressInDevEducationDAL.Tests.Tests
{
    /// <summary>
    /// ������������ ���� �������� ���������� ������ � �������� �������
    /// </summary>
    public class TCities : ATTests
    {
        /// <summary>
        /// ���������� ������ ������ � �������
        /// </summary>
        /// <param name="query">������</param>
        /// <param name="city">�������� ����� � ������</param>
        /// <param name="expected">��������� ���������</param>
        [TestCaseSource(typeof(ECities), nameof(ECities.SetNewCity))]
        public void SetNewCitiesTest(IQuery query, City city, object expected)
        {
            PreparindDB(query.Test);
            var actual = FacadeManager.Cities.SetNewCity(city.Name);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// ��������� ���� ������� �� �������
        /// </summary>
        /// <param name="query">������</param>
        /// <param name="expected">��������� ���������</param>
        [TestCaseSource(typeof(ECities), nameof(ECities.GetAllCities))]
        public void GetAllCitiesTest(IQuery query, object expected)
        {
            PreparindDB(query.Test);
            FacadeManager.Cities.GetAllCities();
            //Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// ���� �� ��������� ������� �������
        /// </summary>
        /// <param name="query">������</param>
        /// <param name="expected">��������� ���������</param>
        [TestCaseSource(typeof(ECities), nameof(ECities.NullifyCities))]
        public void NullifyCitiesTest(IQuery query, object expected)
        {
            PreparindDB(query.Test);
            FacadeManager.Comments.NullifyComments();
            //Assert.AreEqual(expected, actual);
        }
    }
}