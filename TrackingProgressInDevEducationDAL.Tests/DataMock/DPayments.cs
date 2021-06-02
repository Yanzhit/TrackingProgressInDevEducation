using System;
using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Tests.Abstract;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    /// <summary>
    /// База платежей
    /// </summary>
    public class DPayments : ADMock
    {
        /// <summary>
        /// Список платежей для заполнения BD
        /// </summary>
        public List<Payment> Payments { get; }

        /// <summary>
        /// Инициализация базы платежей
        /// </summary>
        public DPayments()
        {
            Payments = new List<Payment>
            {
                new(1, DateTime.MinValue, DateTime.MaxValue, 10m, true),
                new(3, DateTime.MinValue, DateTime.MinValue, 10m, true),
                new(2, DateTime.MinValue, DateTime.MaxValue, 10m, true),
                new(1, DateTime.MinValue, DateTime.MaxValue, 10m, true),
            };
        }
    }
}