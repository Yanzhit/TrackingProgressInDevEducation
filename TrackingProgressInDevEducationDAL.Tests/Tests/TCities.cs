using System;
using NUnit.Framework;
using TrackingProgressInDevEducationDAL.Interfaces;
using TrackingProgressInDevEducationDAL.Models.Bases;
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
        /// <param name="name">�������� ��� ������</param>
        /// <param name="expected">��������� ���������</param>
        [TestCaseSource(typeof(ECities), nameof(ECities.SetNewCity))]
        public void SetNewCitiesTest(IQuery query, City city, object expected)
        {
            PreparindDB(query.Type);
            _manager.Cities.SetNewCity(city.Name);
            //Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// ��������� ���� ������� �� �������
        /// </summary>
        /// <param name="query">������</param>
        /// <param name="expected">��������� ���������</param>
        [TestCaseSource(typeof(ECities), nameof(ECities.GetAllCities))]
        public void GetAllCitiesTest(IQuery query, object expected)
        {
            PreparindDB(query.Type);
            _manager.Cities.GetAllCities();
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
            PreparindDB(query.Type);
            _manager.Cities.NullifyCities();
            //Assert.AreEqual(expected, actual);
        }
    }
}