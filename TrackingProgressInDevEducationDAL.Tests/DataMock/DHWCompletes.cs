using System;
using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Tests.Abstract;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    /// <summary>
    /// База выполненного дз
    /// </summary>
    public class DHWCompletes : ADMock
    {
        /// <summary>
        /// Список выполненного дз для заполнения BD
        /// </summary>
        public List<HWComplete> HWCompletes { get; }

        /// <summary>
        /// Инициализация базы выполненного дз
        /// </summary>
        public DHWCompletes()
        {
            HWCompletes = new List<HWComplete>
            {
                new(new object[] {1, 4, true, "DateTime.MinValue", 1, "DateTime.MaxValue"}),
                new(new object[] {2, 2, false, "DateTime.MinValue", 1, "DateTime.MaxValue"}),
                new(new object[] {3, 3, true, "DateTime.MinValue", 1, "DateTime.MaxValue"}),
                new(new object[] {1, 1, false, "DateTime.MinValue", 1, "DateTime.MaxValue"}),
                new(new object[] {2, 2, false, "DateTime.MinValue", 1, "DateTime.MaxValue"})
            };
        }
    }
}