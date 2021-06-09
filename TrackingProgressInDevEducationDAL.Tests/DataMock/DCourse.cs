using System;
using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using TrackingProgressInDevEducationDAL.Tests.Abstract;

namespace TrackingProgressInDevEducationDAL.Tests.DataMock
{
    /// <summary>
    /// База курсов
    /// </summary>
    public class DCourse : ADMock
    {
        /// <summary>
        /// Список курсов для заполнения BD
        /// </summary>
        public List<Course> Courses { get; }

        /// <summary>
        /// Инициализация базы курсов
        /// </summary>
        public DCourse()
        {
            Courses = new List<Course>
            {
                new(new object[] {"C# - default", "DateTime.MinValue", "DateTime.MaxValue"}),
                new(new object[] {"C# - Front", "DateTime.MinValue", "DateTime.MaxValue"}),
                new(new object[] {"C# - Back", "DateTime.MinValue", "DateTime.MaxValue"}),
                new(new object[] {"C# - Mobile", "DateTime.MinValue", "DateTime.MaxValue"}),
                new(new object[] {"Java - default", "DateTime.MinValue", "DateTime.MaxValue"}),
                new(new object[] {"Java - Front", "DateTime.MinValue", "DateTime.MaxValue"}),
                new(new object[] {"Java - Back", "DateTime.MinValue", "DateTime.MaxValue"}),
                new(new object[] {"Java - Mobile", "DateTime.MinValue", "DateTime.MaxValue"})
            };
        }
    }
}