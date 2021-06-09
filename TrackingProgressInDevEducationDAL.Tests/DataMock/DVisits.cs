using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Tests.Abstract;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    /// <summary>
    /// База посещений
    /// </summary>
    public class DVisits : ADMock
    {
        /// <summary>
        /// Список посещений для заполнения BD
        /// </summary>
        public List<Visit> Visits { get; }

        /// <summary>
        /// Инициализация базы посещений
        /// </summary>
        public DVisits()
        {
            Visits = new List<Visit>
            {
                new(new object[] {true, 3, 1}),
                new(new object[] {true, 3, 4}),
                new(new object[] {false, 2, 1}),
                new(new object[] {false, 1, 3}),
                new(new object[] {true, 3, 2}),
            };
        }
    }
}